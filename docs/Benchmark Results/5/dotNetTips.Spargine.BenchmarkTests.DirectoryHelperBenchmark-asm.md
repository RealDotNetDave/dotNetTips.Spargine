## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.BenchmarkTests.DirectoryHelperBenchmark.CopyDeleteDirectory01()
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp+0FFE0],rsp
       mov       rsi,rcx
       mov       rcx,[rsi+0D8]
       mov       rcx,[rcx+8]
       mov       rdx,2010DD512A0
       mov       rdx,[rdx]
       call      System.IO.Path.Combine(System.String, System.String)
       mov       [rbp+0FFF0],rax
       mov       rcx,[rsi+0D0]
       mov       rdx,[rbp+0FFF0]
       mov       r8d,1
       call      dotNetTips.Spargine.IO.DirectoryHelper.CopyDirectory(System.String, System.String, Boolean)
       nop
       mov       rcx,[rbp+0FFF0]
       mov       edx,3
       call      dotNetTips.Spargine.IO.DirectoryHelper.DeleteDirectory(System.String, Int32)
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       mov       rcx,[rbp+0FFF0]
       mov       edx,3
       call      dotNetTips.Spargine.IO.DirectoryHelper.DeleteDirectory(System.String, Int32)
       nop
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 137
```
```assembly
; System.IO.Path.Combine(System.String, System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.IO.Path.CombineInternal(System.String, System.String)
M01_L00:
       test      rcx,rcx
       je        short M01_L01
       mov       rcx,2012DD51230
       mov       rsi,[rcx]
       jmp       short M01_L02
M01_L01:
       mov       rcx,2012DD51238
       mov       rsi,[rcx]
M01_L02:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 98
```
```assembly
; dotNetTips.Spargine.IO.DirectoryHelper.CopyDirectory(System.String, System.String, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       r8,2011DD53020
       mov       r8,[r8]
       mov       rdx,2010DD512A8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       r8,2011DD53020
       mov       r8,[r8]
       mov       rdx,2010DD512B0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.IO.DirectoryInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       dword ptr [rbp+20],0FFFFFFFF
       mov       rcx,rdi
       call      System.IO.Path.GetFullPath(System.String)
       mov       r8,rax
       mov       dword ptr [rsp+20],1
       mov       rdx,rdi
       mov       rcx,rbp
       xor       r9d,r9d
       call      System.IO.DirectoryInfo.Init(System.String, System.String, System.String, Boolean)
       mov       rcx,rbp
       call      System.IO.DirectoryInfo.GetDirectories()
       mov       rdi,rax
       mov       rcx,rsi
       call      System.IO.Directory.Exists(System.String)
       test      eax,eax
       jne       short M02_L00
       mov       rcx,rsi
       call      System.IO.Directory.CreateDirectory(System.String)
M02_L00:
       mov       rcx,rbp
       call      System.IO.DirectoryInfo.GetFiles()
       mov       rbp,rax
       xor       r14d,r14d
       mov       r15d,[rbp+8]
       test      r15d,r15d
       jle       short M02_L02
       movzx     r13d,bl
M02_L01:
       movsxd    rdx,r14d
       mov       r12,[rbp+rdx*8+10]
       mov       rdx,[r12+18]
       mov       rcx,rsi
       call      System.IO.Path.Combine(System.String, System.String)
       mov       rdx,rax
       mov       r8d,r13d
       mov       rcx,r12
       call      System.IO.FileInfo.CopyTo(System.String, Boolean)
       inc       r14d
       cmp       r15d,r14d
       jg        short M02_L01
M02_L02:
       xor       r12d,r12d
       mov       r13d,[rdi+8]
       test      r13d,r13d
       jle       short M02_L04
       movzx     edx,bl
       mov       ebx,edx
M02_L03:
       movsxd    rdx,r12d
       mov       rdx,[rdi+rdx*8+10]
       mov       rbp,[rdx+8]
       mov       rdx,[rdx+18]
       mov       rcx,rsi
       call      System.IO.Path.Combine(System.String, System.String)
       mov       rdx,rax
       mov       r8d,ebx
       mov       rcx,rbp
       call      dotNetTips.Spargine.IO.DirectoryHelper.CopyDirectory(System.String, System.String, Boolean)
       inc       r12d
       cmp       r13d,r12d
       jg        short M02_L03
M02_L04:
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
; Total bytes of code 332
```
```assembly
; dotNetTips.Spargine.IO.DirectoryHelper.DeleteDirectory(System.String, Int32)
       push      rbp
       push      rsi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+0FFF0],rsp
       mov       [rbp+18],edx
       mov       rsi,rcx
       mov       r8,2011DD53020
       mov       r8,[r8]
       mov       rdx,2012DD51740
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,rsi
       call      System.IO.Directory.Exists(System.String)
       test      eax,eax
       jne       short M03_L00
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
M03_L00:
       cmp       dword ptr [rbp+18],1
       jle       short M03_L01
       mov       ecx,[rbp+18]
       jmp       short M03_L02
M03_L01:
       mov       ecx,1
M03_L02:
       mov       [rbp+18],ecx
       mov       rcx,rsi
       call      dotNetTips.Spargine.IO.DirectoryHelper.SetFileAttributesToNormal(System.String)
       mov       rcx,rsi
       call      System.IO.Path.GetFullPath(System.String)
       mov       rcx,rax
       mov       edx,1
       call      System.IO.FileSystem.RemoveDirectory(System.String, Boolean)
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+30]
       mov       rcx,offset MT_System.IO.IOException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       short M03_L03
       xor       eax,eax
       jmp       short M03_L04
M03_L03:
       cmp       dword ptr [rbp+18],1
       setle     al
       movzx     eax,al
M03_L04:
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+30]
       call      CORINFO_HELP_RETHROW
       int       3
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+30]
       mov       rcx,offset MT_System.UnauthorizedAccessException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       short M03_L05
       xor       eax,eax
       jmp       short M03_L06
M03_L05:
       cmp       dword ptr [rbp+18],1
       setle     al
       movzx     eax,al
M03_L06:
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+30]
       call      CORINFO_HELP_RETHROW
       int       3
; Total bytes of code 300
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.BenchmarkTests.DirectoryHelperBenchmark.CopyMoveDirectory01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       mov       rsi,rcx
       mov       rdi,[rsi+0D0]
       lea       rcx,[rsp+40]
       call      System.Guid.NewGuid()
       mov       rcx,25FDC705A90
       mov       rbx,[rcx]
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      dotNetTips.Spargine.Extensions.GuidExtensions.ToDigits(System.Guid)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.IO.Path.Combine(System.String, System.String)
       mov       rdi,rax
       mov       rcx,[rsi+0D0]
       mov       rdx,rdi
       mov       r8d,1
       call      dotNetTips.Spargine.IO.DirectoryHelper.CopyDirectory(System.String, System.String, Boolean)
       mov       rcx,[rsi+0D8]
       mov       rsi,[rcx+10]
       test      rsi,rsi
       jne       short M00_L00
       mov       rcx,25FEC703020
       mov       rsi,[rcx]
M00_L00:
       lea       rcx,[rsp+30]
       call      System.Guid.NewGuid()
       mov       rcx,25FDC705A90
       mov       rbx,[rcx]
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+20],xmm0
       lea       rcx,[rsp+20]
       call      dotNetTips.Spargine.Extensions.GuidExtensions.ToDigits(System.Guid)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,rsi
       call      System.IO.Path.Combine(System.String, System.String)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,5
       call      dotNetTips.Spargine.IO.DirectoryHelper.MoveDirectory(System.String, System.String, Int32)
       nop
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 230
```
```assembly
; System.Guid.NewGuid()
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       vzeroupper
       lea       rbp,[rsp+40]
       mov       rsi,rcx
       lea       rcx,[rbp+0FFE0]
       call      Interop+Ole32.CoCreateGuid(System.Guid ByRef)
       mov       edi,eax
       test      edi,edi
       jne       short M01_L00
       vmovdqu   xmm0,xmmword ptr [rbp+0FFE0]
       vmovdqu   xmmword ptr [rsi],xmm0
       mov       rax,rsi
       lea       rsp,[rbp+0FFF0]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,offset MT_System.Exception
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.Exception..ctor()
       mov       [rsi+74],edi
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 91
```
```assembly
; dotNetTips.Spargine.Extensions.GuidExtensions.ToDigits(System.Guid)
       mov       r8,25FEC701508
       mov       r8,[r8]
       mov       rdx,25FDC7051F8
       mov       rdx,[rdx]
       jmp       near ptr System.Guid.ToString(System.String, System.IFormatProvider)
; Total bytes of code 31
```
```assembly
; System.String.Concat(System.String, System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       test      rdi,rdi
       je        short M03_L00
       cmp       dword ptr [rdi+8],0
       ja        short M03_L03
M03_L00:
       test      rsi,rsi
       je        short M03_L01
       cmp       dword ptr [rsi+8],0
       ja        short M03_L02
M03_L01:
       mov       rax,25FEC703020
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L02:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L03:
       test      rsi,rsi
       je        short M03_L04
       cmp       dword ptr [rsi+8],0
       ja        short M03_L05
M03_L04:
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L05:
       mov       ebx,[rdi+8]
       mov       ecx,ebx
       add       ecx,[rsi+8]
       call      System.String.FastAllocateString(Int32)
       mov       rbp,rax
       mov       rcx,rbp
       mov       r8,rdi
       xor       edx,edx
       call      System.String.FillStringChecked(System.String, Int32, System.String)
       mov       rcx,rbp
       mov       edx,ebx
       mov       r8,rsi
       call      System.String.FillStringChecked(System.String, Int32, System.String)
       mov       rax,rbp
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 147
```
```assembly
; System.IO.Path.Combine(System.String, System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       je        short M04_L00
       test      rdx,rdx
       je        short M04_L00
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.IO.Path.CombineInternal(System.String, System.String)
M04_L00:
       test      rcx,rcx
       je        short M04_L01
       mov       rcx,25FDC705208
       mov       rsi,[rcx]
       jmp       short M04_L02
M04_L01:
       mov       rcx,25FDC705210
       mov       rsi,[rcx]
M04_L02:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 98
```
```assembly
; dotNetTips.Spargine.IO.DirectoryHelper.CopyDirectory(System.String, System.String, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       r8,25FEC703020
       mov       r8,[r8]
       mov       rdx,25FDC705A98
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       r8,25FEC703020
       mov       r8,[r8]
       mov       rdx,25FDC705AA0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.IO.DirectoryInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       dword ptr [rbp+20],0FFFFFFFF
       mov       rcx,rdi
       call      System.IO.Path.GetFullPath(System.String)
       mov       r8,rax
       mov       dword ptr [rsp+20],1
       mov       rdx,rdi
       mov       rcx,rbp
       xor       r9d,r9d
       call      System.IO.DirectoryInfo.Init(System.String, System.String, System.String, Boolean)
       mov       rcx,rbp
       call      System.IO.DirectoryInfo.GetDirectories()
       mov       rdi,rax
       mov       rcx,rsi
       call      System.IO.Directory.Exists(System.String)
       test      eax,eax
       jne       short M05_L00
       mov       rcx,rsi
       call      System.IO.Directory.CreateDirectory(System.String)
M05_L00:
       mov       rcx,rbp
       call      System.IO.DirectoryInfo.GetFiles()
       mov       rbp,rax
       xor       r14d,r14d
       mov       r15d,[rbp+8]
       test      r15d,r15d
       jle       short M05_L02
       movzx     r13d,bl
M05_L01:
       movsxd    rdx,r14d
       mov       r12,[rbp+rdx*8+10]
       mov       rdx,[r12+18]
       mov       rcx,rsi
       call      System.IO.Path.Combine(System.String, System.String)
       mov       rdx,rax
       mov       r8d,r13d
       mov       rcx,r12
       call      System.IO.FileInfo.CopyTo(System.String, Boolean)
       inc       r14d
       cmp       r15d,r14d
       jg        short M05_L01
M05_L02:
       xor       r12d,r12d
       mov       r13d,[rdi+8]
       test      r13d,r13d
       jle       short M05_L04
       movzx     edx,bl
       mov       ebx,edx
M05_L03:
       movsxd    rdx,r12d
       mov       rdx,[rdi+rdx*8+10]
       mov       rbp,[rdx+8]
       mov       rdx,[rdx+18]
       mov       rcx,rsi
       call      System.IO.Path.Combine(System.String, System.String)
       mov       rdx,rax
       mov       r8d,ebx
       mov       rcx,rbp
       call      dotNetTips.Spargine.IO.DirectoryHelper.CopyDirectory(System.String, System.String, Boolean)
       inc       r12d
       cmp       r13d,r12d
       jg        short M05_L03
M05_L04:
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
; Total bytes of code 332
```
```assembly
; dotNetTips.Spargine.IO.DirectoryHelper.MoveDirectory(System.String, System.String, Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       [rbp+0FFE0],rsp
       mov       [rbp+20],r8d
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,25FEC703020
       mov       r8,[r8]
       mov       rdx,25FDC705AE8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       r8,25FEC703020
       mov       r8,[r8]
       mov       rdx,25FDC705AF0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,rsi
       call      System.IO.Directory.Exists(System.String)
       mov       edx,eax
       mov       r9,25FEC703020
       mov       r9,[r9]
       mov       r8,25FDC705AE8
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       cmp       dword ptr [rbp+20],1
       jle       short M06_L00
       mov       ecx,[rbp+20]
       jmp       short M06_L01
M06_L00:
       mov       ecx,1
M06_L01:
       mov       [rbp+20],ecx
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.IO.Directory.Move(System.String, System.String)
       nop
       lea       rsp,[rbp+0FFF0]
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
       lea       rbp,[rbp+40]
       mov       rcx,offset MT_System.IO.IOException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       short M06_L02
       xor       eax,eax
       jmp       short M06_L03
M06_L02:
       cmp       dword ptr [rbp+20],1
       setle     al
       movzx     eax,al
M06_L03:
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
       lea       rbp,[rbp+40]
       call      CORINFO_HELP_RETHROW
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+40]
       mov       rcx,offset MT_System.UnauthorizedAccessException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       short M06_L04
       xor       eax,eax
       jmp       short M06_L05
M06_L04:
       cmp       dword ptr [rbp+20],1
       setle     al
       movzx     eax,al
M06_L05:
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
       lea       rbp,[rbp+40]
       call      CORINFO_HELP_RETHROW
       int       3
; Total bytes of code 360
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; BenchmarkDotNet.Autogenerated.Runnable_0.__ForDisassemblyDiagnoser__()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
;             if (NotEleven == 11)
;             ^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       cmp       dword ptr [rcx+110],0B
       jne       short M00_L00
;                 AppDataFolder01();
;                 ^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+10]
       call      00007FFB3C5230F8
M00_L00:
       nop
       lea       rsp,[rbp]
       pop       rbp
       ret
; Total bytes of code 43
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.BenchmarkTests.DirectoryHelperBenchmark.DeleteDirectory01()
       sub       rsp,28
       mov       rcx,[rcx+0D8]
       mov       rcx,[rcx+8]
       mov       rdx,13DE66912A0
       mov       rdx,[rdx]
       call      System.IO.Path.Combine(System.String, System.String)
       mov       rcx,rax
       mov       edx,3
       add       rsp,28
       jmp       near ptr dotNetTips.Spargine.IO.DirectoryHelper.DeleteDirectory(System.String, Int32)
; Total bytes of code 50
```
```assembly
; System.IO.Path.Combine(System.String, System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       je        short M01_L00
       test      rdx,rdx
       je        short M01_L00
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.IO.Path.CombineInternal(System.String, System.String)
M01_L00:
       test      rcx,rcx
       je        short M01_L01
       mov       rcx,13E06691230
       mov       rsi,[rcx]
       jmp       short M01_L02
M01_L01:
       mov       rcx,13E06691238
       mov       rsi,[rcx]
M01_L02:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 98
```
```assembly
; dotNetTips.Spargine.IO.DirectoryHelper.DeleteDirectory(System.String, Int32)
       push      rbp
       push      rsi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+0FFF0],rsp
       mov       [rbp+18],edx
       mov       rsi,rcx
       mov       r8,13DD6693020
       mov       r8,[r8]
       mov       rdx,13E06691740
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,rsi
       call      System.IO.Directory.Exists(System.String)
       test      eax,eax
       jne       short M02_L00
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
M02_L00:
       cmp       dword ptr [rbp+18],1
       jle       short M02_L01
       mov       ecx,[rbp+18]
       jmp       short M02_L02
M02_L01:
       mov       ecx,1
M02_L02:
       mov       [rbp+18],ecx
       mov       rcx,rsi
       call      dotNetTips.Spargine.IO.DirectoryHelper.SetFileAttributesToNormal(System.String)
       mov       rcx,rsi
       call      System.IO.Path.GetFullPath(System.String)
       mov       rcx,rax
       mov       edx,1
       call      System.IO.FileSystem.RemoveDirectory(System.String, Boolean)
       nop
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+30]
       mov       rcx,offset MT_System.IO.IOException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       short M02_L03
       xor       eax,eax
       jmp       short M02_L04
M02_L03:
       cmp       dword ptr [rbp+18],1
       setle     al
       movzx     eax,al
M02_L04:
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+30]
       call      CORINFO_HELP_RETHROW
       int       3
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+30]
       mov       rcx,offset MT_System.UnauthorizedAccessException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       short M02_L05
       xor       eax,eax
       jmp       short M02_L06
M02_L05:
       cmp       dword ptr [rbp+18],1
       setle     al
       movzx     eax,al
M02_L06:
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+30]
       call      CORINFO_HELP_RETHROW
       int       3
; Total bytes of code 300
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.BenchmarkTests.DirectoryHelperBenchmark.LoadOneDriveFolders01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      dotNetTips.Spargine.IO.DirectoryHelper.LoadOneDriveFolders()
       mov       [rsp+28],rax
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer(!!0 ByRef)
       call      BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon> ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; dotNetTips.Spargine.IO.DirectoryHelper.LoadOneDriveFolders()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       call      System.Runtime.InteropServices.OSPlatform.get_Windows()
       mov       rcx,rax
       call      System.OperatingSystem.IsOSPlatform(System.String)
       test      al,al
       je        near ptr M01_L07
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.IO.OneDriveFolder, dotNetTips.Spargine.5]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFB3C4B0020
       mov       edx,23
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,2A118742E00
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,2A1487436B0
       mov       rcx,[rcx]
       mov       edx,80000001
       call      dotNetTips.Spargine.Win32.RegistryHelper.GetRegistryKey(System.String, Microsoft.Win32.RegistryHive)
       test      rax,rax
       je        near ptr M01_L06
       mov       rdx,2A1487436B8
       mov       rdx,[rdx]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.RegistryExtensions.GetSubKey(Microsoft.Win32.RegistryKey, System.String)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M01_L06
       mov       rcx,rdi
       call      Microsoft.Win32.RegistryKey.EnsureNotDisposed()
       mov       rcx,rdi
       call      Microsoft.Win32.RegistryKey.InternalSubKeyCountCore()
       test      eax,eax
       jle       near ptr M01_L06
       xor       ebx,ebx
       mov       rcx,rdi
       call      Microsoft.Win32.RegistryKey.GetSubKeyNames()
       cmp       dword ptr [rax+8],0
       jle       near ptr M01_L06
M01_L00:
       mov       rcx,rdi
       call      Microsoft.Win32.RegistryKey.GetSubKeyNames()
       cmp       ebx,[rax+8]
       jae       near ptr M01_L08
       movsxd    rcx,ebx
       mov       rbp,[rax+rcx*8+10]
       mov       rcx,rbp
       call      Microsoft.Win32.RegistryKey.ValidateKeyName(System.String)
       mov       rcx,rdi
       call      Microsoft.Win32.RegistryKey.EnsureNotDisposed()
       mov       rcx,rbp
       call      Microsoft.Win32.RegistryKey.FixupName(System.String)
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      Microsoft.Win32.RegistryKey.InternalOpenSubKeyCore(System.String, Boolean)
       mov       rbp,rax
       mov       rcx,offset MT_dotNetTips.Spargine.IO.OneDriveFolder
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.InitializeFields(System.Object)
       mov       r8,2A1487436C0
       mov       r8,[r8]
       mov       rdx,rbp
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.RegistryExtensions.GetValue(Microsoft.Win32.RegistryKey, System.String)
       call      dotNetTips.Spargine.Extensions.RegistryExtensions.GetValue[[System.__Canon, System.Private.CoreLib]](Microsoft.Win32.RegistryKey, System.String)
       mov       r15,rax
       mov       rcx,r15
       call      dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       test      eax,eax
       je        near ptr M01_L05
       mov       rcx,offset MT_System.IO.DirectoryInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+20],0FFFFFFFF
       mov       rcx,r15
       call      System.IO.Path.GetFullPath(System.String)
       mov       r8,rax
       mov       dword ptr [rsp+20],1
       mov       rdx,r15
       mov       rcx,r12
       xor       r9d,r9d
       call      System.IO.DirectoryInfo.Init(System.String, System.String, System.String, Boolean)
       lea       rcx,[r14+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,2A1487436C8
       mov       r8,[r8]
       mov       rdx,rbp
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.RegistryExtensions.GetValue(Microsoft.Win32.RegistryKey, System.String)
       call      dotNetTips.Spargine.Extensions.RegistryExtensions.GetValue[[System.__Canon, System.Private.CoreLib]](Microsoft.Win32.RegistryKey, System.String)
       test      rax,rax
       je        short M01_L01
       lea       rcx,[r14+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L01:
       mov       r8,2A1487436D0
       mov       r8,[r8]
       mov       rdx,rbp
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.RegistryExtensions.GetValue(Microsoft.Win32.RegistryKey, System.String)
       call      dotNetTips.Spargine.Extensions.RegistryExtensions.GetValue[[System.__Canon, System.Private.CoreLib]](Microsoft.Win32.RegistryKey, System.String)
       mov       r15,rax
       mov       rcx,r15
       call      dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       test      eax,eax
       je        short M01_L02
       mov       dword ptr [r14+20],1
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L03
M01_L02:
       mov       r8,2A148741028
       mov       r8,[r8]
       mov       rdx,rbp
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.RegistryExtensions.GetValue(Microsoft.Win32.RegistryKey, System.String)
       call      dotNetTips.Spargine.Extensions.RegistryExtensions.GetValue[[System.__Canon, System.Private.CoreLib]](Microsoft.Win32.RegistryKey, System.String)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M01_L03:
       mov       rcx,[r14+8]
       call      dotNetTips.Spargine.Extensions.StringExtensions.HasValue(System.String)
       test      eax,eax
       je        short M01_L05
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M01_L05
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       cmp       [rcx+8],edx
       jbe       short M01_L04
       lea       r8d,[rdx+1]
       mov       [rsi+10],r8d
       mov       r8,r14
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L05:
       inc       ebx
       mov       rcx,rdi
       call      Microsoft.Win32.RegistryKey.GetSubKeyNames()
       cmp       [rax+8],ebx
       jg        near ptr M01_L00
M01_L06:
       mov       rdx,rsi
       mov       rcx,offset MD_System.Collections.Immutable.ImmutableArray.ToImmutableArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Collections.Immutable.ImmutableArray.ToImmutableArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L07:
       mov       rcx,offset MT_System.PlatformNotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.PlatformNotSupportedException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 737
```
```assembly
; BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon> ByRef)
       ret
; Total bytes of code 1
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.BenchmarkTests.DirectoryHelperBenchmark.SafeDirectorySearch01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,offset MT_System.IO.DirectoryInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+0D0]
       mov       dword ptr [rdi+20],0FFFFFFFF
       mov       rcx,rbx
       call      System.IO.Path.GetFullPath(System.String)
       mov       r8,rax
       mov       dword ptr [rsp+20],1
       mov       rdx,rbx
       mov       rcx,rdi
       xor       r9d,r9d
       call      System.IO.DirectoryInfo.Init(System.String, System.String, System.String, Boolean)
       mov       rdx,20B9B6336B0
       mov       rdx,[rdx]
       mov       rcx,rdi
       xor       r8d,r8d
       call      dotNetTips.Spargine.IO.DirectoryHelper.SafeDirectorySearch(System.IO.DirectoryInfo, System.String, System.IO.SearchOption)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 126
```
```assembly
; System.IO.Path.GetFullPath(System.String)
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       test      rsi,rsi
       je        short M01_L01
       lea       rcx,[rsi+0C]
       mov       eax,[rsi+8]
       lea       rdx,[rsp+28]
       mov       [rdx],rcx
       mov       [rdx+8],eax
       lea       rcx,[rsp+28]
       call      System.IO.PathInternal.IsEffectivelyEmpty(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       near ptr M01_L02
       lea       rcx,[rsi+0C]
       mov       r8d,[rsi+8]
       xor       edx,edx
       call      System.SpanHelpers.Contains(Char ByRef, Char, Int32)
       test      eax,eax
       jne       near ptr M01_L03
       lea       rcx,[rsi+0C]
       mov       eax,[rsi+8]
       lea       rdx,[rsp+28]
       mov       [rdx],rcx
       mov       [rdx+8],eax
       lea       rcx,[rsp+28]
       call      System.IO.PathInternal.IsExtended(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       je        short M01_L00
       mov       rax,rsi
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rcx,rsi
       call      System.IO.PathHelper.Normalize(System.String)
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1BA97
       mov       rdx,7FFB3C3C4020
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,50EF
       mov       rdx,7FFB3C3C4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1BA97
       mov       rdx,7FFB3C3C4020
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,78A7
       mov       rdx,7FFB3C3C4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1BA97
       mov       rdx,7FFB3C3C4020
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 382
```
```assembly
; System.IO.DirectoryInfo.Init(System.String, System.String, System.String, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,r9
       mov       r14d,[rsp+0B0]
       mov       rdx,rbx
       test      rdx,rdx
       je        near ptr M02_L12
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       short M02_L00
       mov       rsi,rbx
M02_L00:
       test      r14b,r14b
       jne       short M02_L01
       mov       rcx,rsi
       call      System.IO.Path.GetFullPath(System.String)
       jmp       short M02_L02
M02_L01:
       mov       rax,rsi
M02_L02:
       mov       rsi,rax
       mov       rdx,rbp
       test      rdx,rdx
       jne       near ptr M02_L11
       test      rsi,rsi
       jne       short M02_L03
       xor       ecx,ecx
       xor       ebx,ebx
       jmp       short M02_L04
M02_L03:
       lea       rcx,[rsi+0C]
       mov       ebx,[rsi+8]
M02_L04:
       mov       eax,ebx
       lea       rdx,[rsp+20]
       mov       [rdx],rcx
       mov       [rdx+8],eax
       lea       rcx,[rsp+20]
       call      System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       cmp       eax,ebx
       je        short M02_L07
       test      rsi,rsi
       jne       short M02_L05
       xor       ecx,ecx
       xor       edx,edx
       jmp       short M02_L06
M02_L05:
       lea       rcx,[rsi+0C]
       mov       edx,[rsi+8]
M02_L06:
       lea       rax,[rsp+30]
       lea       r8,[rsp+20]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rax
       lea       rdx,[rsp+20]
       call      System.IO.PathInternal.TrimEndingDirectorySeparator(System.ReadOnlySpan`1<Char>)
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+20]
       mov       rax,[rsp+30]
       mov       [rdx],rax
       mov       eax,[rsp+38]
       mov       [rdx+8],eax
       lea       rdx,[rsp+20]
       call      System.IO.Path.GetFileName(System.ReadOnlySpan`1<Char>)
       jmp       short M02_L10
M02_L07:
       test      rsi,rsi
       jne       short M02_L08
       xor       ecx,ecx
       xor       eax,eax
       jmp       short M02_L09
M02_L08:
       lea       rcx,[rsi+0C]
       mov       eax,[rsi+8]
M02_L09:
       mov       [rsp+40],rcx
       mov       [rsp+48],eax
M02_L10:
       mov       rcx,[rsp+40]
       mov       [rsp+50],rcx
       mov       ecx,[rsp+48]
       mov       [rsp+58],ecx
       lea       rcx,[rsp+50]
       call      System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rdx,rax
M02_L11:
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+50],r14b
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L12:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,6DB
       mov       rdx,7FFB3C6BBB28
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 405
```
```assembly
; dotNetTips.Spargine.IO.DirectoryHelper.SafeDirectorySearch(System.IO.DirectoryInfo, System.String, System.IO.SearchOption)
       push      rbp
       push      rsi
       sub       rsp,48
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFD8],rsp
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       r8,20B9B633020
       mov       r8,[r8]
       mov       rdx,20B9B6336B8
       mov       rdx,[rdx]
       mov       rcx,[rbp+10]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.IO.DirectoryInfo, System.String, System.String)
       mov       r8,20B9B633020
       mov       r8,[r8]
       mov       rdx,20B9B6336C0
       mov       rdx,[rdx]
       mov       rcx,[rbp+18]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.IO.DirectoryInfo, System.IO.FileSystem]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFB3C4C0020
       mov       edx,23
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,20B9B632E00
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       edx,[rsi+10]
       cmp       [rcx+8],edx
       jbe       short M03_L00
       lea       r8d,[rdx+1]
       mov       [rsi+10],r8d
       mov       r8,[rbp+10]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M03_L01:
       mov       [rbp+0FFE8],rsi
       xor       ecx,ecx
       mov       [rbp+0FFF4],ecx
       jmp       near ptr M03_L06
M03_L02:
       mov       ecx,[rbp+20]
       call      System.IO.EnumerationOptions.FromSearchOption(System.IO.SearchOption)
       mov       [rsp+20],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+8]
       mov       rcx,[rbp+10]
       mov       r8,[rbp+18]
       mov       r9d,2
       call      System.IO.DirectoryInfo.InternalEnumerateInfos(System.String, System.String, System.IO.SearchTarget, System.IO.EnumerationOptions)
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.Generic.IEnumerable`1[[System.IO.DirectoryInfo, System.IO.FileSystem]]
       call      CORINFO_HELP_CHKCASTARRAY
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       ecx,[rax+8]
       cmp       [rbp+0FFF4],ecx
       jae       short M03_L03
       mov       ecx,[rbp+0FFF4]
       movsxd    rcx,ecx
       mov       rcx,[rax+rcx*8+10]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      dotNetTips.Spargine.IO.DirectoryHelper.SafeDirectorySearch(System.IO.DirectoryInfo, System.String, System.IO.SearchOption)
       mov       rsi,rax
       test      rsi,rsi
       jne       short M03_L04
       jmp       short M03_L05
M03_L03:
       call      CORINFO_HELP_RNGCHKFAIL
M03_L04:
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      r8b
       movzx     r8d,r8b
       test      r8d,r8d
       je        short M03_L05
       mov       r8,rsi
       mov       rdx,[rbp+0FFE8]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, dotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       nop
M03_L05:
       mov       eax,[rbp+0FFF4]
       inc       eax
       mov       [rbp+0FFF4],eax
M03_L06:
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       mov       ecx,[rbp+20]
       call      System.IO.EnumerationOptions.FromSearchOption(System.IO.SearchOption)
       mov       [rsp+20],rax
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+8]
       mov       rcx,[rbp+10]
       mov       r8,[rbp+18]
       mov       r9d,2
       call      System.IO.DirectoryInfo.InternalEnumerateInfos(System.String, System.String, System.IO.SearchTarget, System.IO.EnumerationOptions)
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.Generic.IEnumerable`1[[System.IO.DirectoryInfo, System.IO.FileSystem]]
       call      CORINFO_HELP_CHKCASTARRAY
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       ecx,[rax+8]
       cmp       ecx,[rbp+0FFF4]
       jg        near ptr M03_L02
       mov       rax,[rbp+0FFE8]
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+50]
       mov       rcx,offset MT_System.Exception
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       rdx,rax
       test      rdx,rdx
       jne       short M03_L07
       xor       eax,eax
       jmp       near ptr M03_L10
M03_L07:
       mov       [rbp+0FFE0],rdx
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       short M03_L08
       mov       rdx,[rbp+0FFE0]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       short M03_L08
       mov       rdx,[rbp+0FFE0]
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       short M03_L08
       mov       rdx,[rbp+0FFE0]
       mov       rcx,offset MT_System.IO.DirectoryNotFoundException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       short M03_L08
       mov       rdx,[rbp+0FFE0]
       mov       rcx,offset MT_System.UnauthorizedAccessException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       setne     al
       movzx     eax,al
       jmp       short M03_L09
M03_L08:
       mov       eax,1
M03_L09:
       test      eax,eax
       setne     al
       movzx     eax,al
M03_L10:
       add       rsp,38
       pop       rsi
       pop       rbp
       ret
       push      rbp
       push      rsi
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+50]
       mov       rcx,[rbp+0FFE0]
       mov       rax,[rbp+0FFE0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rcx,rax
       call      System.Diagnostics.Trace.WriteLine(System.String)
       lea       rax,[7FFB3C78F0FD]
       add       rsp,38
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 764
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.BenchmarkTests.DirectoryHelperBenchmark.SafeFileSearch01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,offset MT_System.IO.DirectoryInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rbx,[rsi+0D0]
       mov       dword ptr [rdi+20],0FFFFFFFF
       mov       rcx,rbx
       call      System.IO.Path.GetFullPath(System.String)
       mov       r8,rax
       mov       dword ptr [rsp+20],1
       mov       rdx,rbx
       mov       rcx,rdi
       xor       r9d,r9d
       call      System.IO.DirectoryInfo.Init(System.String, System.String, System.String, Boolean)
       mov       rdx,27DA04F12A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       xor       r8d,r8d
       call      dotNetTips.Spargine.IO.DirectoryHelper.SafeFileSearch(System.IO.DirectoryInfo, System.String, System.IO.SearchOption)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 126
```
```assembly
; System.IO.Path.GetFullPath(System.String)
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       test      rsi,rsi
       je        short M01_L01
       lea       rcx,[rsi+0C]
       mov       eax,[rsi+8]
       lea       rdx,[rsp+28]
       mov       [rdx],rcx
       mov       [rdx+8],eax
       lea       rcx,[rsp+28]
       call      System.IO.PathInternal.IsEffectivelyEmpty(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       near ptr M01_L02
       lea       rcx,[rsi+0C]
       mov       r8d,[rsi+8]
       xor       edx,edx
       call      System.SpanHelpers.Contains(Char ByRef, Char, Int32)
       test      eax,eax
       jne       near ptr M01_L03
       lea       rcx,[rsi+0C]
       mov       eax,[rsi+8]
       lea       rdx,[rsp+28]
       mov       [rdx],rcx
       mov       [rdx+8],eax
       lea       rcx,[rsp+28]
       call      System.IO.PathInternal.IsExtended(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       je        short M01_L00
       mov       rax,rsi
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rcx,rsi
       call      System.IO.PathHelper.Normalize(System.String)
       nop
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1BA97
       mov       rdx,7FFB3C3B4020
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L02:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,50EF
       mov       rdx,7FFB3C3B4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1BA97
       mov       rdx,7FFB3C3B4020
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,78A7
       mov       rdx,7FFB3C3B4020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       rdi,rax
       mov       ecx,1BA97
       mov       rdx,7FFB3C3B4020
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 382
```
```assembly
; System.IO.DirectoryInfo.Init(System.String, System.String, System.String, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rbp,r9
       mov       r14d,[rsp+0B0]
       mov       rdx,rbx
       test      rdx,rdx
       je        near ptr M02_L12
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       short M02_L00
       mov       rsi,rbx
M02_L00:
       test      r14b,r14b
       jne       short M02_L01
       mov       rcx,rsi
       call      System.IO.Path.GetFullPath(System.String)
       jmp       short M02_L02
M02_L01:
       mov       rax,rsi
M02_L02:
       mov       rsi,rax
       mov       rdx,rbp
       test      rdx,rdx
       jne       near ptr M02_L11
       test      rsi,rsi
       jne       short M02_L03
       xor       ecx,ecx
       xor       ebx,ebx
       jmp       short M02_L04
M02_L03:
       lea       rcx,[rsi+0C]
       mov       ebx,[rsi+8]
M02_L04:
       mov       eax,ebx
       lea       rdx,[rsp+20]
       mov       [rdx],rcx
       mov       [rdx+8],eax
       lea       rcx,[rsp+20]
       call      System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       cmp       eax,ebx
       je        short M02_L07
       test      rsi,rsi
       jne       short M02_L05
       xor       ecx,ecx
       xor       edx,edx
       jmp       short M02_L06
M02_L05:
       lea       rcx,[rsi+0C]
       mov       edx,[rsi+8]
M02_L06:
       lea       rax,[rsp+30]
       lea       r8,[rsp+20]
       mov       [r8],rcx
       mov       [r8+8],edx
       mov       rcx,rax
       lea       rdx,[rsp+20]
       call      System.IO.PathInternal.TrimEndingDirectorySeparator(System.ReadOnlySpan`1<Char>)
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+20]
       mov       rax,[rsp+30]
       mov       [rdx],rax
       mov       eax,[rsp+38]
       mov       [rdx+8],eax
       lea       rdx,[rsp+20]
       call      System.IO.Path.GetFileName(System.ReadOnlySpan`1<Char>)
       jmp       short M02_L10
M02_L07:
       test      rsi,rsi
       jne       short M02_L08
       xor       ecx,ecx
       xor       eax,eax
       jmp       short M02_L09
M02_L08:
       lea       rcx,[rsi+0C]
       mov       eax,[rsi+8]
M02_L09:
       mov       [rsp+40],rcx
       mov       [rsp+48],eax
M02_L10:
       mov       rcx,[rsp+40]
       mov       [rsp+50],rcx
       mov       ecx,[rsp+48]
       mov       [rsp+58],ecx
       lea       rcx,[rsp+50]
       call      System.ReadOnlySpan`1[[System.Char, System.Private.CoreLib]].ToString()
       mov       rdx,rax
M02_L11:
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rdi+50],r14b
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L12:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,6DB
       mov       rdx,7FFB3C6ABB28
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 405
```
```assembly
; dotNetTips.Spargine.IO.DirectoryHelper.SafeFileSearch(System.IO.DirectoryInfo, System.String, System.IO.SearchOption)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.IO.DirectoryInfo, System.IO.FileSystem]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,27D804F2E00
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbp+14]
       mov       rcx,[rbp+8]
       mov       edx,[rbp+10]
       cmp       [rcx+8],edx
       jbe       short M03_L00
       lea       r8d,[rdx+1]
       mov       [rbp+10],r8d
       mov       r8,rsi
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M03_L01
M03_L00:
       mov       rcx,rbp
       mov       rdx,rsi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M03_L01:
       mov       rcx,rbp
       mov       rdx,rdi
       mov       r8d,ebx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr dotNetTips.Spargine.IO.DirectoryHelper.SafeFileSearch(System.Collections.Generic.IEnumerable`1<System.IO.DirectoryInfo>, System.String, System.IO.SearchOption)
; Total bytes of code 123
```

## .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
```assembly
; dotNetTips.Spargine.BenchmarkTests.DirectoryHelperBenchmark.SetFileAttributesToNormal01()
       mov       rcx,[rcx+0D0]
       jmp       near ptr dotNetTips.Spargine.IO.DirectoryHelper.SetFileAttributesToNormal(System.String)
; Total bytes of code 12
```
```assembly
; dotNetTips.Spargine.IO.DirectoryHelper.SetFileAttributesToNormal(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,1BE5F8C3020
       mov       r8,[r8]
       mov       rdx,1BE5F8C3B50
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       xor       edi,edi
       mov       rcx,rsi
       call      System.IO.Directory.GetDirectories(System.String)
       cmp       dword ptr [rax+8],0
       jle       short M01_L01
M01_L00:
       mov       rcx,rsi
       call      System.IO.Directory.GetDirectories(System.String)
       cmp       edi,[rax+8]
       jae       short M01_L04
       movsxd    rcx,edi
       mov       rcx,[rax+rcx*8+10]
       call      dotNetTips.Spargine.IO.DirectoryHelper.SetFileAttributesToNormal(System.String)
       inc       edi
       mov       rcx,rsi
       call      System.IO.Directory.GetDirectories(System.String)
       cmp       [rax+8],edi
       jg        short M01_L00
M01_L01:
       xor       edi,edi
       mov       rcx,rsi
       call      System.IO.Directory.GetFiles(System.String)
       cmp       dword ptr [rax+8],0
       jle       short M01_L03
M01_L02:
       mov       rcx,rsi
       call      System.IO.Directory.GetFiles(System.String)
       cmp       edi,[rax+8]
       jae       short M01_L04
       movsxd    rcx,edi
       mov       rcx,[rax+rcx*8+10]
       call      System.IO.Path.GetFullPath(System.String)
       mov       rcx,rax
       mov       edx,80
       call      System.IO.FileSystem.SetAttributes(System.String, System.IO.FileAttributes)
       inc       edi
       mov       rcx,rsi
       call      System.IO.Directory.GetFiles(System.String)
       cmp       [rax+8],edi
       jg        short M01_L02
M01_L03:
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 183
```

