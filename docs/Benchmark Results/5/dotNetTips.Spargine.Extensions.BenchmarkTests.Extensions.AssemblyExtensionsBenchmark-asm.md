## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.Extensions.AssemblyExtensionsBenchmark.GetAllInterfaces01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      System.Reflection.Assembly.GetExecutingAssembly()
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.AssemblyExtensions.GetAllInterfaces(System.Reflection.Assembly)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 46
```
```assembly
; System.Reflection.Assembly.GetExecutingAssembly()
       sub       rsp,28
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+20]
       call      System.Reflection.Assembly.GetExecutingAssembly(System.Threading.StackCrawlMark ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 28
```
```assembly
; dotNetTips.Spargine.Extensions.AssemblyExtensions.GetAllInterfaces(System.Reflection.Assembly)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,19986113020
       mov       r8,[r8]
       mov       rdx,19996115098
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.Type, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,7FFB3C1C0020
       mov       edx,23
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,19996114CB8
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rsi,rax
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M02_L01
M02_L00:
       movsxd    rcx,ebx
       mov       rcx,[rsi+rcx*8+10]
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax]
       mov       r8,rax
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].InsertRange(Int32, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       inc       ebx
       cmp       ebp,ebx
       jg        short M02_L00
M02_L01:
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 182
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.Extensions.AssemblyExtensionsBenchmark.GetAllTypes01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      System.Reflection.Assembly.GetExecutingAssembly()
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.AssemblyExtensions.GetAllTypes(System.Reflection.Assembly)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 46
```
```assembly
; System.Reflection.Assembly.GetExecutingAssembly()
       sub       rsp,28
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+20]
       call      System.Reflection.Assembly.GetExecutingAssembly(System.Threading.StackCrawlMark ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 28
```
```assembly
; dotNetTips.Spargine.Extensions.AssemblyExtensions.GetAllTypes(System.Reflection.Assembly)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,1BEEB253020
       mov       r8,[r8]
       mov       rdx,1BEDB2510C0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rsi,rax
       mov       rcx,1BECB257660
       mov       r8,[rcx]
       test      r8,r8
       jne       short M02_L00
       mov       rcx,offset MT_System.Func`2[[System.Type, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1BECB257658
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M02_L01
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.AssemblyExtensions+<>c.<GetAllTypes>b__1_0(System.Type)
       mov       [rdi+18],rdx
       mov       rcx,1BECB257660
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rdi
M02_L00:
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.Where(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 189
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.Extensions.AssemblyExtensionsBenchmark.GetInstances01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       call      System.Reflection.Assembly.GetExecutingAssembly()
       mov       rdi,rax
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.AssemblyExtensions+<GetInstances>d__2`1[[dotNetTips.Spargine.Extensions.BenchmarkTests.Extensions.AssemblyExtensionsBenchmark, dotNetTips.Spargine.Extensions.BenchmarkTests]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFE
       mov       rcx,7FFB3C1E0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M00_L00
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M00_L00:
       cmp       [rcx],ecx
       call      00007FFB9BD3BEE0
       mov       [rbx+2C],eax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 129
```
```assembly
; System.Reflection.Assembly.GetExecutingAssembly()
       sub       rsp,28
       mov       dword ptr [rsp+20],1
       lea       rcx,[rsp+20]
       call      System.Reflection.Assembly.GetExecutingAssembly(System.Threading.StackCrawlMark ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 28
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
       push      rsi
       sub       rsp,20
       call      qword ptr [7FFB9B851AC8]
       mov       rsi,rax
       call      qword ptr [7FFB9B851748]
       lea       rcx,[rax+18]
       mov       rdx,rsi
       call      qword ptr [7FFB9B851020]
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
