## DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark-20220718-152737
**Diff for AppDataFolder01 method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```diff
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.AppDataFolder01()
        push      rsi
        sub       rsp,20
        mov       rsi,rcx
-       call      000000000000C9A8
-       mov       rcx,[rsi+20]
-       cmp       [rcx],ecx
-       add       rcx,8
+       call      qword ptr [7BA0]
+       mov       rdx,[rsi+20]
+       lea       rcx,[rdx+8]
        mov       rdx,rax
-       call      000000000000B010
+       call      0000000000000010
        nop
        add       rsp,20
        pop       rsi
        ret
-; Total bytes of code 38
+; Total bytes of code 37
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
-       call      0000000000007920
+       call      0000000000008310
        mov       rsi,rax
        mov       rax,rsp
        mov       [rbp+0FF90],rax
        mov       rax,rbp
        mov       [rbp+0FFA0],rax
-       call      00000000000003B8
+       call      qword ptr [10D8]
        mov       rcx,rax
-       call      0000000000000488
-       test      al,al
-       jne       short 0000000000004955
-       mov       rcx,1BEDA0D7F70
+       call      qword ptr [1330]
+       test      eax,eax
+       jne       short 0000000000001C27
+       mov       rcx,1E3A2003028
        mov       rcx,[rcx]
-       jmp       short 0000000000004962
-       mov       rcx,1BEDA0D7F78
+       jmp       short 0000000000001C34
+       mov       rcx,1E3A2003030
        mov       rcx,[rcx]
-       call      000000000000F5B8
+       call      qword ptr [7A38]
        mov       [rbp+0FFB0],rax
-       cmp       byte ptr [53B9],0
-       jne       near ptr 0000000000004A51
+       cmp       byte ptr [5655],0
+       jne       near ptr 0000000000001D29
        xor       ecx,ecx
        mov       [rbp+0FFC0],rcx
        lea       rcx,[rbp+0FFC0]
        mov       rax,offset MD_System.Reflection.Assembly.GetEntryAssemblyNative(System.Runtime.CompilerServices.ObjectHandleOnStack)
        mov       [rbp+0FF80],rax
-       lea       rax,[49B0]
+       lea       rax,[1C83]
        mov       [rbp+0FF98],rax
        lea       rax,[rbp+0FF70]
        mov       [rsi+10],rax
        mov       byte ptr [rsi+0C],0
-       call      qword ptr [0A00]
+       call      qword ptr [67A0]
        mov       byte ptr [rsi+0C],1
-       cmp       dword ptr [59FC],0
-       je        short 00000000000049C3
-       call      qword ptr [7398]
+       cmp       dword ptr [7E8C],0
+       je        short 0000000000001C96
+       call      qword ptr [0A378]
        mov       rcx,[rbp+0FF78]
        mov       [rsi+10],rcx
        mov       rsi,[rbp+0FFC0]
        xor       ecx,ecx
        mov       [rbp+0FFC0],rcx
        mov       rcx,offset MT_System.Reflection.AssemblyCompanyAttribute
-       call      0000000000004F40
+       call      0000000000003330
        mov       rdx,rax
        mov       rcx,rsi
        mov       r8d,1
-       call      00000000000087D0
+       call      qword ptr [1AB0]
        mov       rdx,rax
        mov       rcx,offset MT_System.Collections.Generic.IEnumerable`1[[System.Reflection.AssemblyCompanyAttribute, System.Private.CoreLib]]
-       call      0000000000007450
+       call      qword ptr [5858]
        mov       rdx,rax
        lea       r8,[rbp+0FFB8]
        mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
-       call      000000000000DC48
+       call      qword ptr [0DF48]
        mov       rcx,[rax+8]
-       cmp       [rcx],ecx
+       cmp       [rcx],cl
        mov       edx,3
-       call      0000000000008468
+       call      qword ptr [0D4E0]
        mov       rdx,rax
        mov       rcx,[rbp+0FFB0]
-       call      000000000000A820
+       call      qword ptr [7BB8]
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
        xor       esi,esi
-       jmp       short 00000000000049D8
-; Total bytes of code 357
+       jmp       near ptr 0000000000001CAB
+; Total bytes of code 368
```
**Diff for LoadOneDriveFolders01 method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```diff
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.LoadOneDriveFolders01()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
-       call      000000000000E038
+       call      qword ptr [0D8B8]
        mov       [rsp+28],rax
        mov       rcx,[rsi+20]
-       cmp       [rcx],ecx
+       cmp       [rcx],cl
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer(!!0 ByRef)
-       call      0000000000000BC8
+       call      qword ptr [1A98]
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 58
+; Total bytes of code 60
 ; DotNetTips.Spargine.IO.DirectoryHelper.LoadOneDriveFolders()
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
-       sub       rsp,48
-       lea       rbp,[rsp+70]
+       sub       rsp,58
+       lea       rbp,[rsp+80]
+       vxorps    xmm4,xmm4,xmm4
+       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
        xor       eax,eax
        mov       [rbp+0FFD0],rax
-       mov       [rbp+0FFC8],rax
-       mov       [rbp+0FFB8],rsp
-       call      00000000000003A0
+       mov       [rbp+0FFA8],rsp
+       call      qword ptr [10D8]
        mov       rcx,rax
-       call      0000000000000470
-       test      al,al
-       je        near ptr 000000000000EC21
+       call      qword ptr [1330]
+       test      eax,eax
+       je        near ptr 0000000000007C26
        mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.IO.OneDriveFolder, DotNetTips.Spargine.6]]
-       call      000000000000B2D0
+       call      000000000000EFB0
        mov       rsi,rax
-       mov       rcx,7FF842394928
-       mov       edx,28
-       call      000000000000CB10
-       mov       rdx,1D898BD2FF8
+       mov       rdx,1D3FDC03200
        mov       rdx,[rdx]
        lea       rcx,[rsi+8]
-       call      000000000000AEB0
-       mov       rcx,1D878BD2BA0
+       call      0000000000000010
+       mov       rcx,1D3F9C01C30
        mov       rcx,[rcx]
        mov       edx,80000001
-       call      000000000000E348
-       mov       [rbp+0FFD0],rax
+       call      qword ptr [0F840]
+       mov       [rbp+0FFC8],rax
        test      rax,rax
-       je        near ptr 000000000000EBEA
-       mov       rdx,1D878BD2BA8
+       je        near ptr 0000000000007BA8
+       mov       rdx,1D3F9C01C38
        mov       rdx,[rdx]
        mov       rcx,rax
-       call      000000000000E560
+       call      qword ptr [0FC78]
        mov       rcx,rax
-       mov       [rbp+0FFC8],rcx
+       mov       [rbp+0FFC0],rcx
        test      rcx,rcx
-       je        near ptr 000000000000EBDB
-       call      000000000000E228
-       mov       rcx,[rbp+0FFC8]
-       call      000000000000E2F0
+       je        near ptr 0000000000007B99
+       call      qword ptr [0F4C8]
+       mov       rcx,[rbp+0FFC0]
+       call      qword ptr [0F720]
        test      eax,eax
-       jle       near ptr 000000000000EBDB
+       jle       near ptr 0000000000007B99
        xor       edi,edi
-       jmp       near ptr 000000000000EBBC
-       mov       rcx,[rbp+0FFC8]
-       call      000000000000E1B0
+       jmp       near ptr 0000000000007AE3
+       mov       rcx,[rbp+0FFC0]
+       call      qword ptr [0F360]
        cmp       edi,[rax+8]
-       jae       near ptr 000000000000EBD0
-       movsxd    rcx,edi
+       jae       near ptr 0000000000007AFB
+       mov       ecx,edi
        mov       rbx,[rax+rcx*8+10]
        mov       rcx,rbx
-       call      000000000000E240
-       mov       rcx,[rbp+0FFC8]
-       call      000000000000E228
+       call      qword ptr [0F510]
+       mov       rcx,[rbp+0FFC0]
+       call      qword ptr [0F4C8]
        mov       rcx,rbx
-       call      000000000000E218
+       call      qword ptr [0F498]
        mov       rdx,rax
-       mov       rcx,[rbp+0FFC8]
+       mov       rcx,[rbp+0FFC0]
        xor       r8d,r8d
-       call      000000000000E2D8
-       mov       [rbp+0FFC0],rax
+       call      qword ptr [0F6D8]
+       mov       [rbp+0FFB8],rax
        mov       rcx,offset MT_DotNetTips.Spargine.IO.OneDriveFolder
-       call      000000000000B2D0
+       call      000000000000EFB0
        mov       rbx,rax
        mov       rcx,rbx
-       call      000000000000E398
-       mov       r8,1D878BD2BB0
+       call      qword ptr [0F918]
+       mov       r8,1D3F9C01C40
        mov       r8,[r8]
-       mov       rdx,[rbp+0FFC0]
+       mov       rdx,[rbp+0FFB8]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.RegistryExtensions.GetValue(Microsoft.Win32.RegistryKey, System.String)
-       call      000000000000E578
+       call      qword ptr [0FCA8]
        mov       r14,rax
        test      r14,r14
-       je        near ptr 000000000000EBA6
+       je        near ptr 0000000000007ACD
        mov       rcx,r14
        mov       edx,3
-       call      0000000000008468
+       call      qword ptr [0D4E0]
        cmp       dword ptr [rax+8],0
-       setg      cl
-       movzx     ecx,cl
-       test      ecx,ecx
-       je        near ptr 000000000000EBA6
-       jmp       short 000000000000EA28
-       jmp       near ptr 000000000000EBA6
+       jle       near ptr 0000000000007ACD
        mov       rcx,offset MT_System.IO.DirectoryInfo
-       call      000000000000B2D0
+       call      000000000000EFB0
        mov       r15,rax
        mov       dword ptr [r15+28],0FFFFFFFF
        mov       rcx,r14
-       call      000000000000A888
+       call      qword ptr [7E88]
        mov       r8,rax
        mov       dword ptr [rsp+20],1
        mov       rdx,r14
        mov       rcx,r15
        xor       r9d,r9d
-       call      000000000000AA70
+       call      qword ptr [9480]
        lea       rcx,[rbx+10]
        mov       rdx,r15
-       call      000000000000AEB0
-       mov       r8,1D878BD2BB8
+       call      0000000000000010
+       mov       r8,1D3F9C01C48
        mov       r8,[r8]
-       mov       rdx,[rbp+0FFC0]
+       mov       rdx,[rbp+0FFB8]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.RegistryExtensions.GetValue(Microsoft.Win32.RegistryKey, System.String)
-       call      000000000000E578
+       call      qword ptr [0FCA8]
        test      rax,rax
-       je        short 000000000000EAA0
+       je        short 00000000000079D5
        lea       rcx,[rbx+18]
        mov       rdx,rax
-       call      000000000000AEB0
-       mov       r8,1D878BD2BC0
+       call      0000000000000010
+       mov       r8,1D3F9C01C50
        mov       r8,[r8]
-       mov       rdx,[rbp+0FFC0]
+       mov       rdx,[rbp+0FFB8]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.RegistryExtensions.GetValue(Microsoft.Win32.RegistryKey, System.String)
-       call      000000000000E578
+       call      qword ptr [0FCA8]
        mov       r14,rax
        test      r14,r14
-       je        short 000000000000EAF8
+       je        short 0000000000007A27
        mov       rcx,r14
        mov       edx,3
-       call      0000000000008468
+       call      qword ptr [0D4E0]
        cmp       dword ptr [rax+8],0
-       setg      dl
-       movzx     edx,dl
-       test      edx,edx
-       je        short 000000000000EAF8
+       jle       short 0000000000007A27
        mov       dword ptr [rbx+20],1
        lea       rcx,[rbx+8]
        mov       rdx,r14
-       call      000000000000AEB0
-       jmp       short 000000000000EB46
-       mov       rcx,1D898BD3020
-       mov       r14,[rcx]
-       mov       rcx,[rbp+0FFC0]
-       cmp       [rcx],ecx
-       mov       rcx,[rbp+0FFC0]
-       call      000000000000E228
-       mov       rcx,[rbp+0FFC0]
-       mov       rdx,r14
+       call      0000000000000010
+       jmp       short 0000000000007A74
+       mov       rcx,[rbp+0FFB8]
+       cmp       [rcx],cl
+       mov       rcx,[rbp+0FFB8]
+       call      qword ptr [0F4C8]
+       mov       rdx,1D3F7C02028
+       mov       rdx,[rdx]
+       mov       rcx,[rbp+0FFB8]
        xor       r8d,r8d
        xor       r9d,r9d
-       call      000000000000E310
+       call      qword ptr [0F780]
        mov       rdx,rax
        test      rdx,rdx
-       je        short 000000000000EB3D
+       je        short 0000000000007A6B
        mov       rcx,offset MT_System.String
        cmp       [rdx],rcx
-       jne       short 000000000000EB91
+       jne       short 0000000000007AB6
        lea       rcx,[rbx+8]
-       call      000000000000AEB0
+       call      0000000000000010
        mov       rcx,[rbx+8]
        test      rcx,rcx
-       je        short 000000000000EBA6
+       je        short 0000000000007ACD
        mov       edx,3
-       call      0000000000008468
+       call      qword ptr [0D4E0]
        cmp       dword ptr [rax+8],0
-       setg      cl
-       movzx     ecx,cl
-       test      ecx,ecx
-       je        short 000000000000EBA6
-       mov       rcx,[rbx+10]
-       test      rcx,rcx
-       je        short 000000000000EBA6
+       jle       short 0000000000007ACD
+       cmp       qword ptr [rbx+10],0
+       je        short 0000000000007ACD
        inc       dword ptr [rsi+14]
        mov       rcx,[rsi+8]
        mov       edx,[rsi+10]
        cmp       [rcx+8],edx
-       jbe       short 000000000000EB9A
+       jbe       short 0000000000007AC0
        lea       r8d,[rdx+1]
        mov       [rsi+10],r8d
        mov       r8,rbx
-       call      0000000000008190
-       jmp       short 000000000000EBA6
+       call      0000000000000020
+       jmp       short 0000000000007ACD
        mov       rdx,rax
-       call      0000000000007470
+       call      qword ptr [58B8]
        int       3
        mov       rcx,rsi
        mov       rdx,rbx
-       call      0000000000001458
+       call      qword ptr [3A98]
        nop
-       cmp       qword ptr [rbp+0FFC0],0
-       je        short 000000000000EBB7
-       mov       rcx,[rbp+0FFC0]
-       call      qword ptr [1908]
+       cmp       qword ptr [rbp+0FFB8],0
+       je        short 0000000000007ADE
+       mov       rcx,[rbp+0FFB8]
+       call      qword ptr [8CA0]
        add       edi,1
-       jo        short 000000000000EBD5
-       mov       rcx,[rbp+0FFC8]
-       call      000000000000E1B0
+       jo        short 0000000000007B00
+       mov       rcx,[rbp+0FFC0]
+       call      qword ptr [0F360]
        cmp       [rax+8],edi
-       jg        near ptr 000000000000E976
-       jmp       short 000000000000EBDB
-       call      000000000000F130
-       call      000000000000ECD0
+       jg        near ptr 00000000000078B0
+       jmp       near ptr 0000000000007B99
+       call      00000000000023D0
+       call      0000000000002090
        int       3
-       mov       rcx,[rbp+0FFC8]
+       call      qword ptr [7540]
+       mov       rsi,rax
+       mov       rax,1D3F9C01868
+       mov       rdi,[rax]
+       xor       eax,eax
+       cmp       dword ptr [rdi+8],0
+       sete      al
+       test      eax,eax
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       jne       short 0000000000007B4D
+       call      qword ptr [78B8]
+       mov       rcx,rax
+       mov       rdx,1D3F9C01CC8
+       mov       rdx,[rdx]
+       call      qword ptr [7A08]
+       mov       rcx,rdi
+       mov       edx,3
+       call      qword ptr [0D4E0]
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      000000000000EFB0
+       mov       rbx,rax
+       call      qword ptr [74E0]
+       mov       rdx,rax
+       mov       rcx,rsi
+       call      qword ptr [7978]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [0FB28]
+       mov       rcx,rbx
+       call      0000000000006AD0
+       mov       rcx,[rbp+0FFC0]
        test      rcx,rcx
-       je        short 000000000000EBEA
-       call      qword ptr [1908]
+       je        short 0000000000007BA8
+       call      qword ptr [8CA0]
+       lea       r8,[rbp+0FFD0]
        mov       rdx,rsi
-       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ListExtensions.ToImmutableArray(System.Collections.Generic.IList`1<!!0>)
-       call      000000000000E3F0
-       mov       rdi,rax
-       mov       rax,[rbp+0FFD0]
+       mov       rcx,offset MD_System.Linq.Enumerable.TryGetNonEnumeratedCount(System.Collections.Generic.IEnumerable`1<!!0>, Int32 ByRef)
+       call      qword ptr [19F0]
+       test      eax,eax
+       je        short 0000000000007BCE
+       xor       edx,edx
+       cmp       dword ptr [rbp+0FFD0],0
+       setg      dl
+       jmp       short 0000000000007BD0
+       xor       edx,edx
+       movzx     edx,dl
+       test      edx,edx
+       je        near ptr 0000000000007B06
+       mov       rdx,rsi
+       mov       rcx,offset MD_System.Collections.Generic.EnumerableHelpers.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
+       call      qword ptr [7B58]
+       mov       rdx,rax
+       mov       rcx,offset MD_System.Collections.Immutable.ImmutableArray.Create(!!0[])
+       call      qword ptr [18E8]
+       mov       rsi,rax
+       mov       rax,[rbp+0FFC8]
        test      rax,rax
-       je        short 000000000000EC11
+       je        short 0000000000007C16
        mov       rcx,rax
-       call      qword ptr [1908]
-       mov       rax,rdi
-       add       rsp,48
+       call      qword ptr [8CA0]
+       mov       rax,rsi
+       add       rsp,58
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
        mov       rcx,offset MT_System.PlatformNotSupportedException
-       call      000000000000B2D0
+       call      000000000000EFB0
        mov       rsi,rax
        mov       rcx,rsi
-       call      0000000000001C18
+       call      qword ptr [5C18]
        mov       rcx,rsi
-       call      00000000000055B0
+       call      0000000000006AD0
        int       3
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,38
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
-       lea       rbp,[rbp+70]
-       cmp       qword ptr [rbp+0FFC0],0
-       je        short 000000000000EC6E
-       mov       rcx,[rbp+0FFC0]
-       call      qword ptr [1908]
+       lea       rbp,[rbp+80]
+       cmp       qword ptr [rbp+0FFB8],0
+       je        short 0000000000007C77
+       mov       rcx,[rbp+0FFB8]
+       call      qword ptr [8CA0]
        nop
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,38
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
-       lea       rbp,[rbp+70]
-       cmp       qword ptr [rbp+0FFC8],0
-       je        short 000000000000ECA6
-       mov       rcx,[rbp+0FFC8]
-       call      qword ptr [1908]
+       lea       rbp,[rbp+80]
+       cmp       qword ptr [rbp+0FFC0],0
+       je        short 0000000000007CB2
+       mov       rcx,[rbp+0FFC0]
+       call      qword ptr [8CA0]
        nop
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
        push      rbp
        push      r15
        push      r14
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,38
        mov       rbp,[rcx+28]
        mov       [rsp+28],rbp
-       lea       rbp,[rbp+70]
-       cmp       qword ptr [rbp+0FFD0],0
-       je        short 000000000000ECDE
-       mov       rcx,[rbp+0FFD0]
-       call      qword ptr [1908]
+       lea       rbp,[rbp+80]
+       cmp       qword ptr [rbp+0FFC8],0
+       je        short 0000000000007CED
+       mov       rcx,[rbp+0FFC8]
+       call      qword ptr [8CA0]
        nop
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       r14
        pop       r15
        pop       rbp
        ret
-; Total bytes of code 1100
+; Total bytes of code 1307
 ; BenchmarkDotNet.Engines.Consumer.ValueTypesConsumer[[System.Collections.Immutable.ImmutableArray`1[[System.__Canon, System.Private.CoreLib]], System.Collections.Immutable]](System.Collections.Immutable.ImmutableArray`1<System.__Canon> ByRef)
        ret
 ; Total bytes of code 1
```
**Diff for SafeDirectorySearch01 method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```diff
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.SafeDirectorySearch01()
        push      rsi
        sub       rsp,20
        mov       rsi,rcx
        mov       rcx,[rsi+0B8]
-       mov       rdx,290419BB798
+       mov       rdx,25D49C00C18
        mov       rdx,[rdx]
        xor       r8d,r8d
-       call      000000000000C408
-       mov       rcx,[rsi+20]
-       cmp       [rcx],ecx
-       add       rcx,10
+       call      qword ptr [7C60]
+       mov       rdx,[rsi+20]
+       lea       rcx,[rdx+10]
        mov       rdx,rax
-       call      000000000000B010
+       call      0000000000000010
        nop
        add       rsp,20
        pop       rsi
        ret
-; Total bytes of code 61
+; Total bytes of code 60
 ; DotNetTips.Spargine.IO.DirectoryHelper.SafeDirectorySearch(System.IO.DirectoryInfo, System.String, System.IO.SearchOption)
        push      rbp
        push      rdi
        push      rsi
-       sub       rsp,50
-       lea       rbp,[rsp+60]
+       push      rbx
+       sub       rsp,58
+       lea       rbp,[rsp+70]
        xor       eax,eax
-       mov       [rbp+0FFD8],rax
-       mov       [rbp+0FFC0],rsp
+       mov       [rbp+0FFD0],rax
+       mov       [rbp+0FFB8],rsp
        mov       [rbp+10],rcx
        mov       [rbp+18],rdx
        mov       [rbp+20],r8d
-       mov       r8,290419B3020
-       mov       r8,[r8]
-       mov       r9,290419B98D8
-       mov       r9,[r9]
-       mov       rcx,[rbp+10]
-       xor       edx,edx
-       call      0000000000001B78
-       mov       [rbp+10],rax
+       mov       rsi,[rbp+10]
+       cmp       qword ptr [rbp+10],0
+       jne       near ptr 00000000000016C1
+       call      qword ptr [74E0]
+       mov       rsi,rax
+       mov       ecx,6
+       call      000000000000A000
+       mov       rdi,rax
+       cmp       dword ptr [rdi+8],4
+       jl        near ptr 0000000000001A32
+       lea       rcx,[rdi+0C]
+       mov       rdx,25D4DC00508
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       r8d,8
+       call      qword ptr [5810]
+       mov       ecx,[rdi+8]
+       sub       ecx,4
+       cmp       ecx,2
+       jl        near ptr 0000000000001A55
+       lea       rcx,[rdi+14]
+       mov       rdx,25D4BC02090
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       r8d,4
+       call      qword ptr [5810]
+       mov       rcx,rdi
+       mov       rdx,rsi
+       call      qword ptr [0BC60]
+       mov       rcx,rax
+       test      rcx,rcx
+       je        short 00000000000015E2
+       xor       eax,eax
+       cmp       dword ptr [rcx+8],0
+       sete      al
+       jmp       short 00000000000015E7
+       mov       eax,1
+       test      eax,eax
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       jne       near ptr 0000000000001682
+       call      qword ptr [78B8]
+       mov       rsi,rax
+       mov       ecx,9
+       mov       rdx,7FF842C49668
+       call      000000000000F510
+       mov       rdi,rax
+       mov       ecx,36B
+       mov       rdx,7FF842C49668
+       call      000000000000F510
+       mov       rcx,rax
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7270]
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      000000000000EFB0
+       mov       rbx,rax
+       call      qword ptr [74E0]
+       mov       rdx,rax
+       mov       rcx,rsi
+       call      qword ptr [7978]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [0FB28]
+       mov       rcx,rbx
+       call      0000000000006AD0
+       cmp       [rcx],cl
+       mov       edx,3
+       call      qword ptr [0D4E0]
+       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      000000000000EFB0
+       mov       rdi,rax
+       call      qword ptr [74E0]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rdi
+       call      qword ptr [0FB28]
+       mov       rcx,rdi
+       call      0000000000006AD0
+       mov       rcx,rsi
+       call      qword ptr [0DEA8]
+       test      eax,eax
+       jne       near ptr 00000000000017BF
+       call      qword ptr [75D0]
+       mov       rcx,rax
+       mov       r8,[rsi+8]
+       mov       rdx,25D49C00C30
+       mov       rdx,[rdx]
+       call      qword ptr [0BC78]
+       mov       rdi,rax
+       mov       ecx,6
+       call      000000000000A000
+       mov       rbx,rax
+       cmp       dword ptr [rbx+8],4
+       jl        near ptr 0000000000001A78
+       lea       rcx,[rbx+0C]
+       mov       rdx,25D4DC00508
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       r8d,8
+       call      qword ptr [5810]
+       mov       ecx,[rbx+8]
+       sub       ecx,4
+       cmp       ecx,2
+       jl        near ptr 0000000000001A9B
+       lea       rcx,[rbx+14]
+       mov       rdx,25D4BC02090
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       r8d,4
+       call      qword ptr [5810]
+       mov       rcx,rbx
+       mov       rdx,rdi
+       call      qword ptr [0BC60]
+       mov       rdi,rax
+       call      qword ptr [75E8]
+       mov       rdx,rax
+       mov       rcx,rdi
+       call      qword ptr [7978]
+       mov       rdi,rax
+       mov       rcx,offset MT_DotNetTips.Spargine.Core.DirectoryNotFoundException
+       call      000000000000EFB0
+       mov       rbx,rax
+       mov       rcx,rbx
+       call      qword ptr [0FC00]
+       lea       rcx,[rbx+10]
+       mov       rdx,rdi
+       call      0000000000000010
+       lea       rcx,[rbx+88]
+       mov       rdx,rsi
+       call      0000000000000010
+       mov       rcx,rbx
+       call      0000000000006AD0
+       mov       [rbp+10],rsi
        mov       rcx,[rbp+18]
        cmp       qword ptr [rbp+18],0
-       je        short 000000000000DA60
-       cmp       dword ptr [rcx+8],0
-       je        short 000000000000DA60
+       je        short 00000000000017E7
        xor       eax,eax
-       jmp       short 000000000000DA65
-       mov       eax,1
+       cmp       dword ptr [rcx+8],0
+       sete      al
        test      eax,eax
        sete      al
        movzx     eax,al
+       cmp       dword ptr [rcx+8],0
+       jne       short 00000000000017E9
+       jmp       short 00000000000017E9
+       xor       eax,eax
        test      eax,eax
-       jne       short 000000000000DA99
-       call      0000000000001E58
+       jne       near ptr 0000000000001893
+       call      qword ptr [78B8]
        mov       rsi,rax
        mov       ecx,29B
-       mov       rdx,7FF84270B680
-       call      0000000000000390
+       mov       rdx,7FF842E126C0
+       call      000000000000F510
+       mov       rdi,rax
+       mov       ecx,9
+       mov       rdx,7FF842C49668
+       call      000000000000F510
+       mov       rbx,rax
+       mov       ecx,36B
+       mov       rdx,7FF842C49668
+       call      000000000000F510
+       mov       rcx,rdi
+       mov       r9,rbx
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7270]
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      000000000000EFB0
+       mov       rbx,rax
+       call      qword ptr [74E0]
        mov       rdx,rax
        mov       rcx,rsi
-       call      0000000000000C00
-       int       3
-       cmp       [rcx],ecx
+       call      qword ptr [7978]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [0FB28]
+       mov       rcx,rbx
+       call      0000000000006AD0
+       cmp       [rcx],cl
        mov       edx,3
-       call      0000000000008468
+       call      qword ptr [0D4E0]
        mov       [rbp+18],rax
        mov       esi,[rbp+20]
        mov       rcx,offset MT_System.IO.SearchOption
-       call      000000000000B2D0
+       call      000000000000EFB0
        mov       rdi,rax
        mov       rcx,offset MT_System.IO.SearchOption
-       call      0000000000004F40
+       call      0000000000003330
        mov       rcx,rax
        mov       edx,[rbp+20]
        mov       [rdi+8],edx
        mov       rdx,rdi
-       call      0000000000000948
+       call      qword ptr [1678]
        test      eax,eax
-       jne       short 000000000000DB0A
-       call      0000000000001D70
-       mov       rsi,rax
-       mov       ecx,263
-       mov       rdx,7FF84270B680
-       call      0000000000000390
-       mov       rdx,rax
-       mov       rcx,rsi
-       call      0000000000000C18
-       int       3
+       je        near ptr 0000000000001ABE
        mov       [rbp+20],esi
        mov       rcx,offset MT_System.Collections.Generic.List`1[[System.IO.DirectoryInfo, System.Private.CoreLib]]
-       call      000000000000B2D0
-       mov       [rbp+0FFD0],rax
-       mov       rcx,7FF842394928
-       mov       edx,28
-       call      000000000000CB10
-       mov       rdx,290419B2FF8
-       mov       rdx,[rdx]
-       mov       rax,[rbp+0FFD0]
+       call      000000000000EFB0
+       mov       [rbp+0FFC8],rax
+       mov       rdx,25D4BC075F8
+       mov       rsi,[rdx]
        lea       rcx,[rax+8]
-       call      000000000000AEB0
-       mov       rax,[rbp+0FFD0]
+       mov       rdx,rsi
+       call      0000000000000010
+       mov       rax,[rbp+0FFC8]
        inc       dword ptr [rax+14]
-       mov       rcx,[rax+8]
+       mov       rcx,rsi
        mov       edx,[rax+10]
        cmp       [rcx+8],edx
-       jbe       short 000000000000DB78
+       jbe       short 0000000000001936
        lea       r8d,[rdx+1]
-       mov       [rbp+0FFD0],rax
        mov       [rax+10],r8d
        mov       r8,[rbp+10]
-       call      0000000000008190
-       jmp       short 000000000000DB88
-       mov       [rbp+0FFD0],rax
+       call      0000000000000020
+       jmp       short 0000000000001943
        mov       rcx,rax
        mov       rdx,[rbp+10]
-       call      0000000000001458
-       mov       rax,[rbp+0FFD0]
-       mov       [rbp+0FFE0],rax
+       call      qword ptr [3A98]
+       mov       rax,[rbp+0FFC8]
+       mov       [rbp+0FFD8],rax
        xor       ecx,ecx
-       mov       [rbp+0FFEC],ecx
-       mov       rcx,[rbp+10]
-       cmp       [rcx],ecx
+       mov       [rbp+0FFE4],ecx
        mov       ecx,[rbp+20]
-       call      000000000000D7E0
+       call      qword ptr [9960]
        mov       r8,rax
        mov       rdx,[rbp+18]
        mov       rcx,[rbp+10]
-       call      000000000000AAE8
+       call      qword ptr [95E8]
        cmp       dword ptr [rax+8],0
-       jle       near ptr 000000000000DC66
+       jle       near ptr 0000000000001A20
        mov       ecx,[rbp+20]
-       call      000000000000D7E0
+       call      qword ptr [9960]
        mov       r8,rax
        mov       rdx,[rbp+18]
        mov       rcx,[rbp+10]
-       call      000000000000AAE8
+       call      qword ptr [95E8]
        mov       ecx,[rax+8]
-       cmp       [rbp+0FFEC],ecx
-       jae       short 000000000000DC10
-       mov       ecx,[rbp+0FFEC]
-       movsxd    rcx,ecx
+       cmp       [rbp+0FFE4],ecx
+       jae       short 00000000000019C7
+       mov       ecx,[rbp+0FFE4]
        mov       rcx,[rax+rcx*8+10]
        mov       rdx,[rbp+18]
        xor       r8d,r8d
-       call      000000000000C408
+       call      qword ptr [7C60]
        mov       rsi,rax
        test      rsi,rsi
-       je        short 000000000000DC37
+       je        short 00000000000019EF
        mov       rcx,rsi
-       call      000000000000D4E8
+       call      qword ptr [9048]
+       xor       r8d,r8d
        test      eax,eax
        setg      r8b
-       movzx     r8d,r8b
-       jmp       short 000000000000DC15
-       call      000000000000F130
+       jmp       short 00000000000019CC
+       call      00000000000023D0
        test      r8d,r8d
-       je        short 000000000000DC37
+       je        short 00000000000019EF
        mov       r8,rsi
-       mov       rdx,[rbp+0FFE0]
+       mov       rdx,[rbp+0FFD8]
        mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
        mov       r9d,0FFFFFFFF
-       call      000000000000D620
+       call      qword ptr [9408]
        nop
-       mov       ecx,[rbp+0FFEC]
+       mov       ecx,[rbp+0FFE4]
        add       ecx,1
-       jo        short 000000000000DC72
-       mov       [rbp+0FFEC],ecx
+       jo        short 0000000000001A2D
+       mov       [rbp+0FFE4],ecx
        mov       ecx,[rbp+20]
-       call      000000000000D7E0
+       call      qword ptr [9960]
        mov       r8,rax
        mov       rdx,[rbp+18]
        mov       rcx,[rbp+10]
-       call      000000000000AAE8
+       call      qword ptr [95E8]
        mov       eax,[rax+8]
-       cmp       eax,[rbp+0FFEC]
-       jg        near ptr 000000000000DBBD
-       mov       rax,[rbp+0FFE0]
-       add       rsp,50
+       cmp       eax,[rbp+0FFE4]
+       jg        near ptr 0000000000001974
+       mov       rax,[rbp+0FFD8]
+       add       rsp,58
+       pop       rbx
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-       call      000000000000ECD0
+       call      0000000000002090
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      000000000000EFB0
+       mov       rsi,rax
+       mov       rcx,rsi
+       call      qword ptr [5F48]
+       mov       rcx,rsi
+       call      0000000000006AD0
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      000000000000EFB0
+       mov       rsi,rax
+       mov       rcx,rsi
+       call      qword ptr [5F48]
+       mov       rcx,rsi
+       call      0000000000006AD0
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      000000000000EFB0
+       mov       rsi,rax
+       mov       rcx,rsi
+       call      qword ptr [5F48]
+       mov       rcx,rsi
+       call      0000000000006AD0
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      000000000000EFB0
+       mov       rsi,rax
+       mov       rcx,rsi
+       call      qword ptr [5F48]
+       mov       rcx,rsi
+       call      0000000000006AD0
+       call      qword ptr [7600]
+       mov       rsi,rax
+       mov       rax,25D49C00C28
+       mov       rcx,[rax]
+       xor       eax,eax
+       cmp       dword ptr [rcx+8],0
+       sete      al
+       test      eax,eax
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       jne       near ptr 0000000000001B78
+       call      qword ptr [78B8]
+       mov       rsi,rax
+       mov       ecx,9
+       mov       rdx,7FF842C49668
+       call      000000000000F510
+       mov       rdi,rax
+       mov       ecx,36B
+       mov       rdx,7FF842C49668
+       call      000000000000F510
+       mov       rcx,rax
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7270]
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      000000000000EFB0
+       mov       rbx,rax
+       call      qword ptr [74E0]
+       mov       rdx,rax
+       mov       rcx,rsi
+       call      qword ptr [7978]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [0FB28]
+       mov       rcx,rbx
+       call      0000000000006AD0
+       mov       edx,3
+       call      qword ptr [0D4E0]
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentOutOfRangeException
+       call      000000000000EFB0
+       mov       rbx,rax
+       call      qword ptr [74F8]
+       mov       rdx,rax
+       mov       rcx,rsi
+       call      qword ptr [7978]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [3030]
+       mov       rcx,rbx
+       call      0000000000006AD0
        int       3
        push      rbp
        push      rdi
        push      rsi
-       sub       rsp,30
-       mov       rbp,[rcx+20]
-       mov       [rsp+20],rbp
-       lea       rbp,[rbp+60]
+       push      rbx
+       sub       rsp,38
+       mov       rbp,[rcx+28]
+       mov       [rsp+28],rbp
+       lea       rbp,[rbp+70]
        mov       rcx,offset MT_System.Exception
-       call      0000000000007440
+       call      qword ptr [5828]
        mov       rdx,rax
        test      rdx,rdx
-       jne       short 000000000000DCA7
+       jne       short 0000000000001BF3
        xor       eax,eax
-       jmp       short 000000000000DD02
-       mov       [rbp+0FFD8],rdx
+       jmp       short 0000000000001C51
+       mov       [rbp+0FFD0],rdx
        mov       rcx,offset MT_System.ArgumentException
-       call      0000000000007440
+       call      qword ptr [5828]
        test      rax,rax
-       jne       short 000000000000DCF5
-       mov       rdx,[rbp+0FFD8]
+       jne       short 0000000000001C44
+       mov       rdx,[rbp+0FFD0]
        mov       rcx,offset MT_System.IO.DirectoryNotFoundException
-       call      0000000000007440
+       call      qword ptr [5828]
        test      rax,rax
-       jne       short 000000000000DCF5
-       mov       rdx,[rbp+0FFD8]
+       jne       short 0000000000001C44
+       mov       rdx,[rbp+0FFD0]
        mov       rcx,offset MT_System.UnauthorizedAccessException
-       call      0000000000007440
+       call      qword ptr [5828]
        test      rax,rax
        setne     al
        movzx     eax,al
-       jmp       short 000000000000DCFA
+       jmp       short 0000000000001C49
        mov       eax,1
        test      eax,eax
        setne     al
        movzx     eax,al
-       add       rsp,30
+       add       rsp,38
+       pop       rbx
        pop       rsi
        pop       rdi
        pop       rbp
        ret
        push      rbp
        push      rdi
        push      rsi
-       sub       rsp,30
-       mov       rbp,[rcx+20]
-       mov       [rsp+20],rbp
-       lea       rbp,[rbp+60]
-       mov       rcx,[rbp+0FFD8]
-       mov       rax,[rbp+0FFD8]
+       push      rbx
+       sub       rsp,38
+       mov       rbp,[rcx+28]
+       mov       [rsp+28],rbp
+       lea       rbp,[rbp+70]
+       mov       rcx,[rbp+0FFD0]
+       mov       rax,[rbp+0FFD0]
        mov       rax,[rax]
        mov       rax,[rax+40]
        call      qword ptr [rax+20]
        mov       rcx,rax
-       call      000000000000D748
-       lea       rax,[0DC37]
-       add       rsp,30
+       call      qword ptr [9738]
+       lea       rax,[19EF]
+       add       rsp,38
+       pop       rbx
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 839
+; Total bytes of code 1914
```
**Diff for SafeFileSearch01 method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```diff
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.SafeFileSearch01()
        push      rdi
        push      rsi
+       push      rbp
        push      rbx
-       sub       rsp,20
+       sub       rsp,28
        mov       rsi,rcx
        mov       rdi,[rsi+0B8]
        mov       rcx,offset MT_System.Collections.Generic.List`1[[System.IO.DirectoryInfo, System.Private.CoreLib]]
-       call      000000000000B2D0
+       call      000000000000EFB0
        mov       rbx,rax
-       mov       rdx,1E6FE592FF8
-       mov       rdx,[rdx]
+       mov       rdx,256A48031B8
+       mov       rbp,[rdx]
        lea       rcx,[rbx+8]
-       call      000000000000AEB0
+       mov       rdx,rbp
+       call      0000000000000010
        inc       dword ptr [rbx+14]
-       mov       rcx,[rbx+8]
+       mov       rcx,rbp
        mov       edx,[rbx+10]
        cmp       [rcx+8],edx
-       jbe       short 0000000000007E7A
+       jbe       short 00000000000022AD
        lea       r8d,[rdx+1]
        mov       [rbx+10],r8d
        mov       r8,rdi
-       call      0000000000008190
-       jmp       short 0000000000007E85
+       call      0000000000000020
+       jmp       short 00000000000022B9
        mov       rcx,rbx
        mov       rdx,rdi
-       call      0000000000001458
-       mov       rdx,1E6FE599F68
+       call      qword ptr [3A98]
+       mov       rdx,256A0805020
        mov       rdx,[rdx]
        mov       rcx,rbx
        xor       r8d,r8d
-       call      000000000000D4A0
-       mov       rcx,[rsi+20]
-       cmp       [rcx],ecx
-       add       rcx,10
+       call      qword ptr [9360]
+       mov       rdx,[rsi+20]
+       lea       rcx,[rdx+10]
        mov       rdx,rax
-       call      000000000000B010
+       call      0000000000000010
        nop
-       add       rsp,20
+       add       rsp,28
        pop       rbx
+       pop       rbp
        pop       rsi
        pop       rdi
        ret
-; Total bytes of code 152
+; Total bytes of code 156
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
+       mov       rcx,[rsi+8]
+       cmp       dword ptr [rcx+8],0
+       jne       short 0000000000000B2D
+       mov       ecx,4
+       cmp       ecx,7FFFFFC7
+       ja        short 0000000000000B3E
+       cmp       ecx,edx
+       mov       [rsp+24],ecx
+       jl        short 0000000000000B38
        mov       rcx,rsi
-       call      00000000000014D8
+       mov       edx,[rsp+24]
+       call      qword ptr [3960]
        mov       [rsi+10],ebp
        mov       rcx,[rsi+8]
        mov       edx,ebx
        mov       r8,rdi
-       call      0000000000008190
+       call      0000000000000020
        nop
        add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
-; Total bytes of code 57
+       mov       rcx,[rsi+8]
+       mov       ecx,[rcx+8]
+       add       ecx,ecx
+       jmp       short 0000000000000AF5
+       mov       [rsp+24],edx
+       jmp       short 0000000000000B05
+       mov       eax,7FFFFFC7
+       mov       ecx,eax
+       jmp       short 0000000000000AFD
+; Total bytes of code 119
 ; DotNetTips.Spargine.IO.DirectoryHelper.SafeFileSearch(System.Collections.Generic.IEnumerable`1<System.IO.DirectoryInfo>, System.String, System.IO.SearchOption)
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,28
+       sub       rsp,38
+       xor       eax,eax
+       mov       [rsp+30],rax
        mov       rsi,rcx
        mov       rdi,rdx
        mov       ebx,r8d
        mov       rcx,offset MT_DotNetTips.Spargine.IO.DirectoryHelper+<>c__DisplayClass10_0
-       call      000000000000B2D0
+       call      000000000000EFB0
        mov       rbp,rax
        lea       rcx,[rbp+8]
        mov       rdx,rdi
-       call      000000000000AEB0
+       call      0000000000000010
        mov       [rbp+18],ebx
-       mov       r9,1E6FE599F70
-       mov       r9,[r9]
-       mov       r8,1E6FE593020
-       mov       r8,[r8]
+       test      rsi,rsi
+       je        short 0000000000002416
+       lea       r8,[rsp+30]
        mov       rdx,rsi
-       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentItemsExists(System.Collections.Generic.IEnumerable`1<!!0>, System.String, System.String)
-       call      000000000000D4E0
-       mov       rsi,rax
+       mov       rcx,offset MD_System.Linq.Enumerable.TryGetNonEnumeratedCount(System.Collections.Generic.IEnumerable`1<!!0>, Int32 ByRef)
+       call      qword ptr [9510]
+       test      eax,eax
+       je        short 0000000000002416
+       xor       eax,eax
+       cmp       dword ptr [rsp+30],0
+       setg      al
+       jmp       short 0000000000002418
+       xor       eax,eax
+       movzx     eax,al
+       test      eax,eax
+       je        near ptr 00000000000025E1
        mov       rcx,[rbp+8]
        test      rcx,rcx
-       je        near ptr 0000000000008126
-       cmp       dword ptr [rcx+8],0
-       je        near ptr 0000000000008126
-       xor       eax,eax
+       je        short 0000000000002444
+       mov       eax,[rcx+8]
+       xor       edx,edx
        test      eax,eax
-       sete      al
-       movzx     eax,al
+       sete      dl
+       test      edx,edx
+       sete      dl
+       movzx     edx,dl
        test      eax,eax
-       jne       short 000000000000801E
-       call      0000000000001E58
+       jne       short 0000000000002446
+       jmp       short 0000000000002446
+       xor       edx,edx
+       test      edx,edx
+       jne       near ptr 00000000000024F0
+       call      qword ptr [78B8]
        mov       rbp,rax
        mov       ecx,29B
-       mov       rdx,7FF84270B9A0
-       call      0000000000000390
+       mov       rdx,7FF842E429E0
+       call      000000000000F510
+       mov       rsi,rax
+       mov       ecx,9
+       mov       rdx,7FF842C79668
+       call      000000000000F510
+       mov       rdi,rax
+       mov       ecx,36B
+       mov       rdx,7FF842C79668
+       call      000000000000F510
+       mov       rcx,rsi
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7270]
+       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      000000000000EFB0
+       mov       rdi,rax
+       call      qword ptr [74E0]
        mov       rdx,rax
        mov       rcx,rbp
-       call      0000000000000C00
-       int       3
-       cmp       [rcx],ecx
+       call      qword ptr [7978]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rdi
+       call      qword ptr [0FB28]
+       mov       rcx,rdi
+       call      0000000000006AD0
+       cmp       [rcx],cl
        mov       edx,3
-       call      0000000000008468
+       call      qword ptr [0D4E0]
        lea       rcx,[rbp+8]
        mov       rdx,rax
-       call      000000000000AEB0
+       call      0000000000000010
        mov       edi,[rbp+18]
        mov       rcx,offset MT_System.IO.SearchOption
-       call      000000000000B2D0
+       call      000000000000EFB0
        mov       rbx,rax
        mov       rcx,offset MT_System.IO.SearchOption
-       call      0000000000004F40
-       mov       rcx,rax
+       call      0000000000003330
        mov       [rbx+8],edi
+       test      rax,rax
+       je        near ptr 0000000000002674
        mov       rdx,rbx
-       call      0000000000000948
+       mov       rcx,rax
+       call      qword ptr [8A70]
        test      eax,eax
-       jne       short 0000000000008094
-       call      0000000000001D70
-       mov       rdi,rax
-       mov       ecx,263
-       mov       rdx,7FF84270B9A0
-       call      0000000000000390
-       mov       rdx,rax
-       mov       rcx,rdi
-       call      0000000000000C18
-       int       3
+       je        near ptr 0000000000002692
        mov       [rbp+18],edi
        mov       rcx,offset MT_System.Collections.Generic.List`1[[System.IO.FileInfo, System.Private.CoreLib]]
-       call      000000000000B2D0
+       call      000000000000EFB0
        mov       rdi,rax
-       mov       rdx,1E6FE593000
+       mov       rdx,256A48031C0
        mov       rdx,[rdx]
        lea       rcx,[rdi+8]
-       call      000000000000AEB0
+       call      0000000000000010
        lea       rcx,[rbp+10]
        mov       rdx,rdi
-       call      000000000000AEB0
+       call      0000000000000010
        mov       rcx,offset MT_System.Action`1[[System.IO.DirectoryInfo, System.Private.CoreLib]]
-       call      000000000000B2D0
+       call      000000000000EFB0
        mov       rdi,rax
        mov       rdx,rsi
        mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
-       call      000000000000D510
+       call      qword ptr [9438]
        mov       rsi,rax
        lea       rcx,[rdi+8]
        mov       rdx,rbp
-       call      000000000000AEB0
+       call      0000000000000010
        mov       rcx,offset DotNetTips.Spargine.IO.DirectoryHelper+<>c__DisplayClass10_0.<SafeFileSearch>b__0(System.IO.DirectoryInfo)
        mov       [rdi+18],rcx
        mov       rcx,rsi
        mov       rdx,rdi
        cmp       [rcx],ecx
-       call      0000000000001530
+       call      qword ptr [3D20]
        mov       rax,[rbp+10]
-       add       rsp,28
+       add       rsp,38
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
        ret
-       mov       eax,1
-       jmp       near ptr 0000000000007FEA
-; Total bytes of code 448
+       call      qword ptr [7540]
+       mov       rsi,rax
+       mov       rax,256A0805028
+       mov       rdi,[rax]
+       xor       eax,eax
+       cmp       dword ptr [rdi+8],0
+       sete      al
+       test      eax,eax
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       jne       short 0000000000002628
+       call      qword ptr [78B8]
+       mov       rcx,rax
+       mov       rdx,256A08050B0
+       mov       rdx,[rdx]
+       call      qword ptr [7A08]
+       mov       rcx,rdi
+       mov       edx,3
+       call      qword ptr [0D4E0]
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      000000000000EFB0
+       mov       rbx,rax
+       call      qword ptr [74E0]
+       mov       rdx,rax
+       mov       rcx,rsi
+       call      qword ptr [7978]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [0FB28]
+       mov       rcx,rbx
+       call      0000000000006AD0
+       mov       ecx,2E7
+       mov       rdx,7FF8427E4000
+       call      000000000000F510
+       mov       rcx,rax
+       call      qword ptr [0FBA0]
+       int       3
+       call      qword ptr [7600]
+       mov       rsi,rax
+       mov       rax,256A0805038
+       mov       rcx,[rax]
+       xor       eax,eax
+       cmp       dword ptr [rcx+8],0
+       sete      al
+       test      eax,eax
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       jne       near ptr 000000000000274C
+       call      qword ptr [78B8]
+       mov       rsi,rax
+       mov       ecx,9
+       mov       rdx,7FF842C79668
+       call      000000000000F510
+       mov       rdi,rax
+       mov       ecx,36B
+       mov       rdx,7FF842C79668
+       call      000000000000F510
+       mov       rcx,rax
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7270]
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      000000000000EFB0
+       mov       rbx,rax
+       call      qword ptr [74E0]
+       mov       rdx,rax
+       mov       rcx,rsi
+       call      qword ptr [7978]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [0FB28]
+       mov       rcx,rbx
+       call      0000000000006AD0
+       mov       edx,3
+       call      qword ptr [0D4E0]
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentOutOfRangeException
+       call      000000000000EFB0
+       mov       rbx,rax
+       call      qword ptr [74F8]
+       mov       rdx,rax
+       mov       rcx,rsi
+       call      qword ptr [7978]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [3030]
+       mov       rcx,rbx
+       call      0000000000006AD0
+       int       3
+; Total bytes of code 998
```
**Diff for SetFileAttributesToNormal01 method between:**
.NET 6.0.7 (6.0.722.32202), X64 RyuJIT
.NET 7.0.0 (7.0.22.32404), X64 RyuJIT
```diff
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.SetFileAttributesToNormal01()
        mov       rcx,[rcx+0B8]
-       jmp       near ptr 000000000000C420
-; Total bytes of code 12
+       jmp       qword ptr [9108]
+; Total bytes of code 13
 ; DotNetTips.Spargine.IO.DirectoryHelper.SetFileAttributesToNormal(System.IO.DirectoryInfo)
+       push      r15
        push      r14
+       push      r13
+       push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,20
+       sub       rsp,28
        mov       rsi,rcx
-       mov       r8,2BEC6583020
-       mov       r8,[r8]
-       mov       r9,2BEB65814F8
-       mov       r9,[r9]
-       mov       rcx,rsi
-       xor       edx,edx
-       call      0000000000001B78
+       test      rsi,rsi
+       jne       near ptr 00000000000000EB
+       call      qword ptr [74E0]
+       mov       rsi,rax
+       mov       ecx,6
+       call      000000000000A000
+       mov       rdi,rax
+       cmp       dword ptr [rdi+8],4
+       jl        near ptr 000000000000045F
+       lea       rcx,[rdi+0C]
+       mov       rdx,1F8E6804910
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       r8d,8
+       call      qword ptr [5810]
+       mov       ecx,[rdi+8]
+       sub       ecx,4
+       cmp       ecx,2
+       jl        near ptr 0000000000000482
+       lea       rcx,[rdi+14]
+       mov       rdx,1F8E6802090
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       r8d,4
+       call      qword ptr [5810]
+       mov       rcx,rdi
+       mov       rdx,rsi
+       call      qword ptr [0BC60]
+       mov       rcx,rax
+       test      rcx,rcx
+       je        short 000000000000000C
+       xor       eax,eax
+       cmp       dword ptr [rcx+8],0
+       sete      al
+       jmp       short 0000000000000011
+       mov       eax,1
+       test      eax,eax
+       sete      al
+       movzx     eax,al
+       test      eax,eax
+       jne       near ptr 00000000000000AC
+       call      qword ptr [78B8]
        mov       rsi,rax
+       mov       ecx,9
+       mov       rdx,7FF842C89668
+       call      000000000000F510
+       mov       rdi,rax
+       mov       ecx,36B
+       mov       rdx,7FF842C89668
+       call      000000000000F510
+       mov       rcx,rax
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7270]
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      000000000000EFB0
+       mov       rbx,rax
+       call      qword ptr [74E0]
+       mov       rdx,rax
        mov       rcx,rsi
-       cmp       [rcx],ecx
-       call      000000000000AAD0
+       call      qword ptr [7978]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [0FB28]
+       mov       rcx,rbx
+       call      0000000000006AD0
+       cmp       [rcx],cl
+       mov       edx,3
+       call      qword ptr [0D4E0]
+       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      000000000000EFB0
        mov       rdi,rax
-       xor       ebx,ebx
+       call      qword ptr [74E0]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rdi
+       call      qword ptr [0FB28]
+       mov       rcx,rdi
+       call      0000000000006AD0
        mov       rcx,rsi
-       call      000000000000AAD0
-       cmp       dword ptr [rax+8],0
-       jle       short 000000000000D519
-       mov       r14d,[rdi+8]
-       cmp       ebx,r14d
-       jae       short 000000000000D573
-       movsxd    rcx,ebx
+       call      qword ptr [0DEA8]
+       test      eax,eax
+       jne       near ptr 00000000000003F1
+       call      qword ptr [75D0]
+       mov       rdi,rax
+       mov       rbx,[rsi+8]
+       test      rdi,rdi
+       je        short 000000000000011F
+       cmp       dword ptr [rdi+8],0
+       je        short 000000000000011F
+       test      rbx,rbx
+       je        near ptr 000000000000028E
+       jmp       short 000000000000013D
+       mov       rcx,1F8E4800C18
+       mov       rcx,[rcx]
+       mov       rdx,rbx
+       call      qword ptr [0BC60]
+       mov       rbp,rax
+       jmp       near ptr 00000000000001C4
+       cmp       dword ptr [rbx+8],0
+       je        near ptr 000000000000028E
+       mov       ecx,[rdi+8]
+       mov       eax,[rbx+8]
+       lea       ecx,[rcx+rax+0B]
+       call      000000000000A000
+       mov       rbp,rax
+       mov       r8d,[rdi+8]
+       cmp       r8d,[rbp+8]
+       jg        near ptr 00000000000004EB
+       lea       rcx,[rbp+0C]
+       lea       rdx,[rdi+0C]
+       mov       r8d,[rdi+8]
+       add       r8,r8
+       call      qword ptr [5810]
+       mov       ecx,[rdi+8]
+       mov       edx,[rbp+8]
+       sub       edx,ecx
+       cmp       edx,0B
+       jl        near ptr 000000000000050E
+       movsxd    rcx,ecx
+       lea       rcx,[rbp+rcx*2+0C]
+       mov       rdx,1F8E4800C18
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       r8d,16
+       call      qword ptr [5810]
+       mov       edx,[rdi+8]
+       add       edx,0B
+       mov       rcx,rbp
+       mov       r8,rbx
+       call      qword ptr [0BBB8]
+       mov       ecx,6
+       call      000000000000A000
+       mov       rdi,rax
+       cmp       dword ptr [rdi+8],4
+       jl        near ptr 0000000000000531
+       lea       rcx,[rdi+0C]
+       mov       rdx,1F8E6804910
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       r8d,8
+       call      qword ptr [5810]
+       mov       ecx,[rdi+8]
+       sub       ecx,4
+       cmp       ecx,2
+       jl        near ptr 0000000000000554
+       lea       rcx,[rdi+14]
+       mov       rdx,1F8E6802090
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       r8d,4
+       call      qword ptr [5810]
+       mov       rcx,rdi
+       mov       rdx,rbp
+       call      qword ptr [0BC60]
+       mov       rdi,rax
+       call      qword ptr [75E8]
+       mov       rdx,rax
+       mov       rcx,rdi
+       call      qword ptr [7978]
+       mov       rdi,rax
+       mov       rcx,offset MT_DotNetTips.Spargine.Core.DirectoryNotFoundException
+       call      000000000000EFB0
+       mov       rbx,rax
+       mov       rcx,rbx
+       call      qword ptr [0FC00]
+       lea       rcx,[rbx+10]
+       mov       rdx,rdi
+       call      0000000000000010
+       lea       rcx,[rbx+88]
+       mov       rdx,rsi
+       call      0000000000000010
+       mov       rcx,rbx
+       call      0000000000006AD0
+       cmp       dword ptr [rdi+8],0
+       je        short 0000000000000304
+       mov       ebp,[rdi+8]
+       lea       ecx,[rbp+0B]
+       call      000000000000A000
+       mov       rbx,rax
+       mov       r8d,[rdi+8]
+       mov       r14d,[rbx+8]
+       cmp       r8d,r14d
+       jg        near ptr 00000000000004A5
+       lea       r15,[rbx+0C]
+       mov       rcx,r15
+       lea       rdx,[rdi+0C]
+       mov       r8d,[rdi+8]
+       add       r8,r8
+       call      qword ptr [5810]
+       sub       r14d,ebp
+       cmp       r14d,0B
+       jl        near ptr 00000000000004C8
+       movsxd    rcx,ebp
+       lea       rcx,[r15+rcx*2]
+       mov       rdx,1F8E4800C18
+       mov       rdx,[rdx]
+       add       rdx,0C
+       mov       r8d,16
+       call      qword ptr [5810]
+       mov       rbp,rbx
+       jmp       near ptr 00000000000001C4
+       mov       rcx,1F8E4800C18
+       mov       rbp,[rcx]
+       jmp       short 00000000000002FF
+       cmp       ebx,[rdi+8]
+       jae       near ptr 0000000000000578
+       mov       ecx,ebx
        mov       rcx,[rdi+rcx*8+10]
-       call      000000000000C420
+       call      qword ptr [9108]
        add       ebx,1
-       jo        short 000000000000D56D
+       jo        near ptr 000000000000045A
+       mov       r12,rbp
+       mov       rcx,r14
+       call      000000000000EFB0
+       mov       r13,rax
+       mov       [rsp+20],r12
+       mov       rdx,[rsi+8]
+       mov       r8,r15
        mov       rcx,rsi
-       call      000000000000AAD0
+       mov       r9d,2
+       call      qword ptr [9720]
+       mov       rdx,rax
+       mov       rcx,offset MT_System.Collections.Generic.IEnumerable`1[[System.IO.DirectoryInfo, System.Private.CoreLib]]
+       call      qword ptr [5858]
+       mov       rdx,rax
+       mov       rcx,r13
+       call      qword ptr [3930]
+       mov       rcx,r13
+       call      qword ptr [3F90]
        cmp       [rax+8],ebx
-       jg        short 000000000000D4F5
-       xor       ebp,ebp
-       mov       rcx,rsi
-       call      000000000000AAD0
-       cmp       dword ptr [rax+8],0
-       jle       short 000000000000D562
-       mov       r14d,[rdi+8]
-       cmp       ebp,r14d
-       jae       short 000000000000D573
-       movsxd    rcx,ebp
-       mov       rcx,[rdi+rcx*8+10]
-       mov       rcx,[rcx+8]
-       call      000000000000A888
-       mov       rcx,rax
-       mov       edx,80
-       call      00000000000014B8
-       add       ebp,1
-       jo        short 000000000000D56D
-       mov       rcx,rsi
-       call      000000000000AAD0
-       cmp       [rax+8],ebp
-       jg        short 000000000000D52D
-       add       rsp,20
+       jg        short 0000000000000313
+       xor       ebx,ebx
+       mov       r12,rbp
+       mov       rcx,r14
+       call      000000000000EFB0
+       mov       r13,rax
+       mov       [rsp+20],r12
+       mov       rdx,[rsi+8]
+       mov       r8,r15
+       mov       rcx,rsi
+       mov       r9d,2
+       call      qword ptr [9720]
+       mov       rdx,rax
+       mov       rcx,offset MT_System.Collections.Generic.IEnumerable`1[[System.IO.DirectoryInfo, System.Private.CoreLib]]
+       call      qword ptr [5858]
+       mov       rdx,rax
+       mov       rcx,r13
+       call      qword ptr [3930]
+       mov       rcx,r13
+       call      qword ptr [3F90]
+       cmp       [rax+8],ebx
+       jg        short 0000000000000428
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
+       pop       r12
+       pop       r13
        pop       r14
+       pop       r15
        ret
-       call      000000000000ECD0
+       mov       rcx,rsi
+       call      qword ptr [95A0]
+       mov       rdi,rax
+       xor       ebx,ebx
+       mov       rcx,1F8E68015B0
+       mov       rbp,[rcx]
+       mov       r14,offset MT_System.Collections.Generic.List`1[[System.IO.DirectoryInfo, System.Private.CoreLib]]
+       mov       rcx,1F8E68045A0
+       mov       r15,[rcx]
+       jmp       near ptr 0000000000000332
+       cmp       ebx,[rdi+8]
+       jae       near ptr 0000000000000578
+       mov       ecx,ebx
+       mov       rcx,[rdi+rcx*8+10]
+       mov       rcx,[rcx+8]
+       call      qword ptr [7E88]
+       mov       rcx,rax
+       mov       edx,80
+       call      qword ptr [5408]
+       add       ebx,1
+       jo        short 000000000000045A
+       jmp       near ptr 000000000000038A
+       call      0000000000002090
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      000000000000EFB0
+       mov       rsi,rax
+       mov       rcx,rsi
+       call      qword ptr [5F48]
+       mov       rcx,rsi
+       call      0000000000006AD0
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      000000000000EFB0
+       mov       rsi,rax
+       mov       rcx,rsi
+       call      qword ptr [5F48]
+       mov       rcx,rsi
+       call      0000000000006AD0
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      000000000000EFB0
+       mov       rsi,rax
+       mov       rcx,rsi
+       call      qword ptr [5F48]
+       mov       rcx,rsi
+       call      0000000000006AD0
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      000000000000EFB0
+       mov       rsi,rax
+       mov       rcx,rsi
+       call      qword ptr [5F48]
+       mov       rcx,rsi
+       call      0000000000006AD0
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      000000000000EFB0
+       mov       rsi,rax
+       mov       rcx,rsi
+       call      qword ptr [5F48]
+       mov       rcx,rsi
+       call      0000000000006AD0
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      000000000000EFB0
+       mov       rsi,rax
+       mov       rcx,rsi
+       call      qword ptr [5F48]
+       mov       rcx,rsi
+       call      0000000000006AD0
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      000000000000EFB0
+       mov       rsi,rax
+       mov       rcx,rsi
+       call      qword ptr [5F48]
+       mov       rcx,rsi
+       call      0000000000006AD0
+       mov       rcx,offset MT_System.IndexOutOfRangeException
+       call      000000000000EFB0
+       mov       rsi,rax
+       mov       rcx,rsi
+       call      qword ptr [5F48]
+       mov       rcx,rsi
+       call      0000000000006AD0
        int       3
-       call      000000000000F130
+       call      00000000000023D0
        int       3
-; Total bytes of code 217
+; Total bytes of code 1566
```
