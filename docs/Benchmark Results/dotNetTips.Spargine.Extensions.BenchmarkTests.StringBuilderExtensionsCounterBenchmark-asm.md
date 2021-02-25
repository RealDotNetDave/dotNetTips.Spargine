## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendBytes(this.ByteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
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
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB17169498]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 125
```
```assembly
; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,135E2893060
       mov       r8,[r8]
       mov       rdx,135E28A01E0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,135E2893060
       mov       r8,[r8]
       mov       rdx,135E28933F8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rdx,135E28A01E8
       mov       rdx,[rdx]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rdi+rcx+10]
       mov       rax,135E2891528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,135E28A01F0
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rsi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       edx,27
       call      System.Text.StringBuilder.Append(Char)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 208
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       jne       short M02_L00
       mov       rax,135E2893060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M02_L01
       xor       ebx,ebx
       jmp       short M02_L02
M02_L01:
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rbx,[rsp+28]
M02_L02:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L03
       mov       rcx,[rsi+8]
       mov       edx,[rsi+1C]
       lea       eax,[r8+rdx]
       cmp       eax,[rdi+8]
       ja        short M02_L04
       mov       eax,[rcx+8]
       cmp       eax,r8d
       jb        short M02_L04
       cmp       eax,0
       jbe       near ptr M02_L05
       add       rcx,10
       mov       [rsp+20],rcx
       mov       rax,[rsp+20]
       movsxd    rcx,edx
       lea       rcx,[rbx+rcx*2]
       add       r8d,r8d
       mov       rdx,rax
       call      System.Buffer.Memmove(Byte*, Byte*, UIntPtr)
       xor       eax,eax
       mov       [rsp+20],rax
M02_L03:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L02
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,9B41
       mov       rdx,7FFB16D34020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       ecx,1A2D3
       mov       rdx,7FFB16D34020
       call      CORINFO_HELP_STRCNS
       lea       rcx,[rsi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 325
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendBytes(this.ByteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
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
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB17159498]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 125
```
```assembly
; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1F2EE9E3060
       mov       r8,[r8]
       mov       rdx,1F30E9E3A08
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1F2EE9E3060
       mov       r8,[r8]
       mov       rdx,1F2EE9E33F8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rdx,1F30E9E3A10
       mov       rdx,[rdx]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rdi+rcx+10]
       mov       rax,1F2EE9E1528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1F30E9E3A18
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rsi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       edx,27
       call      System.Text.StringBuilder.Append(Char)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 208
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       jne       short M02_L00
       mov       rax,1F2EE9E3060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M02_L01
       xor       ebx,ebx
       jmp       short M02_L02
M02_L01:
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rbx,[rsp+28]
M02_L02:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L03
       mov       rcx,[rsi+8]
       mov       edx,[rsi+1C]
       lea       eax,[r8+rdx]
       cmp       eax,[rdi+8]
       ja        short M02_L04
       mov       eax,[rcx+8]
       cmp       eax,r8d
       jb        short M02_L04
       cmp       eax,0
       jbe       near ptr M02_L05
       add       rcx,10
       mov       [rsp+20],rcx
       mov       rax,[rsp+20]
       movsxd    rcx,edx
       lea       rcx,[rbx+rcx*2]
       add       r8d,r8d
       mov       rdx,rax
       call      System.Buffer.Memmove(Byte*, Byte*, UIntPtr)
       xor       eax,eax
       mov       [rsp+20],rax
M02_L03:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L02
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,9B41
       mov       rdx,7FFB16D24020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       ecx,1A2D3
       mov       rdx,7FFB16D24020
       call      CORINFO_HELP_STRCNS
       lea       rcx,[rsi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 325
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendBytes(this.ByteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
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
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB17179498]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 125
```
```assembly
; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,24C089F1048
       mov       r8,[r8]
       mov       rdx,24BF89F11B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,24C089F1048
       mov       r8,[r8]
       mov       rdx,24C089F13E0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rdx,24BF89F11C0
       mov       rdx,[rdx]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rdi+rcx+10]
       mov       rax,24BE89F1528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,24BF89F11C8
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rsi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       edx,27
       call      System.Text.StringBuilder.Append(Char)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 208
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       jne       short M02_L00
       mov       rax,24C089F1048
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M02_L01
       xor       ebx,ebx
       jmp       short M02_L02
M02_L01:
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rbx,[rsp+28]
M02_L02:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L03
       mov       rcx,[rsi+8]
       mov       edx,[rsi+1C]
       lea       eax,[r8+rdx]
       cmp       eax,[rdi+8]
       ja        short M02_L04
       mov       eax,[rcx+8]
       cmp       eax,r8d
       jb        short M02_L04
       cmp       eax,0
       jbe       near ptr M02_L05
       add       rcx,10
       mov       [rsp+20],rcx
       mov       rax,[rsp+20]
       movsxd    rcx,edx
       lea       rcx,[rbx+rcx*2]
       add       r8d,r8d
       mov       rdx,rax
       call      System.Buffer.Memmove(Byte*, Byte*, UIntPtr)
       xor       eax,eax
       mov       [rsp+20],rax
M02_L03:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L02
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,9B41
       mov       rdx,7FFB16D44020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       ecx,1A2D3
       mov       rdx,7FFB16D44020
       call      CORINFO_HELP_STRCNS
       lea       rcx,[rsi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 325
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendBytes(this.ByteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
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
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB17159498]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 125
```
```assembly
; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1790CD63060
       mov       r8,[r8]
       mov       rdx,1793CD611B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1790CD63060
       mov       r8,[r8]
       mov       rdx,1790CD633F8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rdx,1793CD611C0
       mov       rdx,[rdx]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rdi+rcx+10]
       mov       rax,1790CD61528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1793CD611C8
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rsi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       edx,27
       call      System.Text.StringBuilder.Append(Char)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 208
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       jne       short M02_L00
       mov       rax,1790CD63060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M02_L01
       xor       ebx,ebx
       jmp       short M02_L02
M02_L01:
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rbx,[rsp+28]
M02_L02:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L03
       mov       rcx,[rsi+8]
       mov       edx,[rsi+1C]
       lea       eax,[r8+rdx]
       cmp       eax,[rdi+8]
       ja        short M02_L04
       mov       eax,[rcx+8]
       cmp       eax,r8d
       jb        short M02_L04
       cmp       eax,0
       jbe       near ptr M02_L05
       add       rcx,10
       mov       [rsp+20],rcx
       mov       rax,[rsp+20]
       movsxd    rcx,edx
       lea       rcx,[rbx+rcx*2]
       add       r8d,r8d
       mov       rdx,rax
       call      System.Buffer.Memmove(Byte*, Byte*, UIntPtr)
       xor       eax,eax
       mov       [rsp+20],rax
M02_L03:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L02
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,9B41
       mov       rdx,7FFB16D24020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       ecx,1A2D3
       mov       rdx,7FFB16D24020
       call      CORINFO_HELP_STRCNS
       lea       rcx,[rsi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 325
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendBytes(this.ByteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
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
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB17169498]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 125
```
```assembly
; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,28717F13060
       mov       r8,[r8]
       mov       rdx,28747F111B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,28717F13060
       mov       r8,[r8]
       mov       rdx,28717F133F8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rdx,28747F111C0
       mov       rdx,[rdx]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rdi+rcx+10]
       mov       rax,28717F11528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,28747F111C8
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rsi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       edx,27
       call      System.Text.StringBuilder.Append(Char)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 208
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       jne       short M02_L00
       mov       rax,28717F13060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M02_L01
       xor       ebx,ebx
       jmp       short M02_L02
M02_L01:
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rbx,[rsp+28]
M02_L02:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L03
       mov       rcx,[rsi+8]
       mov       edx,[rsi+1C]
       lea       eax,[r8+rdx]
       cmp       eax,[rdi+8]
       ja        short M02_L04
       mov       eax,[rcx+8]
       cmp       eax,r8d
       jb        short M02_L04
       cmp       eax,0
       jbe       near ptr M02_L05
       add       rcx,10
       mov       [rsp+20],rcx
       mov       rax,[rsp+20]
       movsxd    rcx,edx
       lea       rcx,[rbx+rcx*2]
       add       r8d,r8d
       mov       rdx,rax
       call      System.Buffer.Memmove(Byte*, Byte*, UIntPtr)
       xor       eax,eax
       mov       [rsp+20],rax
M02_L03:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L02
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,9B41
       mov       rdx,7FFB16D34020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       ecx,1A2D3
       mov       rdx,7FFB16D34020
       call      CORINFO_HELP_STRCNS
       lea       rcx,[rsi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 325
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendBytes(this.ByteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
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
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB17179498]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 125
```
```assembly
; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,21066DD3060
       mov       r8,[r8]
       mov       rdx,21066DD3608
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,21066DD3060
       mov       r8,[r8]
       mov       rdx,21066DD33F8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rdx,21066DD3610
       mov       rdx,[rdx]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rdi+rcx+10]
       mov       rax,21066DD1528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,21066DD3618
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rsi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       edx,27
       call      System.Text.StringBuilder.Append(Char)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 208
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       jne       short M02_L00
       mov       rax,21066DD3060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M02_L01
       xor       ebx,ebx
       jmp       short M02_L02
M02_L01:
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rbx,[rsp+28]
M02_L02:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L03
       mov       rcx,[rsi+8]
       mov       edx,[rsi+1C]
       lea       eax,[r8+rdx]
       cmp       eax,[rdi+8]
       ja        short M02_L04
       mov       eax,[rcx+8]
       cmp       eax,r8d
       jb        short M02_L04
       cmp       eax,0
       jbe       near ptr M02_L05
       add       rcx,10
       mov       [rsp+20],rcx
       mov       rax,[rsp+20]
       movsxd    rcx,edx
       lea       rcx,[rbx+rcx*2]
       add       r8d,r8d
       mov       rdx,rax
       call      System.Buffer.Memmove(Byte*, Byte*, UIntPtr)
       xor       eax,eax
       mov       [rsp+20],rax
M02_L03:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L02
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,9B41
       mov       rdx,7FFB16D44020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       ecx,1A2D3
       mov       rdx,7FFB16D44020
       call      CORINFO_HELP_STRCNS
       lea       rcx,[rsi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 325
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendBytes(this.ByteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
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
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB17149498]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 125
```
```assembly
; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,23375E83060
       mov       r8,[r8]
       mov       rdx,23365E811B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,23375E83060
       mov       r8,[r8]
       mov       rdx,23375E833F8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rdx,23365E811C0
       mov       rdx,[rdx]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rdi+rcx+10]
       mov       rax,23375E81528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,23365E811C8
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rsi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       edx,27
       call      System.Text.StringBuilder.Append(Char)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 208
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       jne       short M02_L00
       mov       rax,23375E83060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M02_L01
       xor       ebx,ebx
       jmp       short M02_L02
M02_L01:
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rbx,[rsp+28]
M02_L02:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L03
       mov       rcx,[rsi+8]
       mov       edx,[rsi+1C]
       lea       eax,[r8+rdx]
       cmp       eax,[rdi+8]
       ja        short M02_L04
       mov       eax,[rcx+8]
       cmp       eax,r8d
       jb        short M02_L04
       cmp       eax,0
       jbe       near ptr M02_L05
       add       rcx,10
       mov       [rsp+20],rcx
       mov       rax,[rsp+20]
       movsxd    rcx,edx
       lea       rcx,[rbx+rcx*2]
       add       r8d,r8d
       mov       rdx,rax
       call      System.Buffer.Memmove(Byte*, Byte*, UIntPtr)
       xor       eax,eax
       mov       [rsp+20],rax
M02_L03:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L02
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,9B41
       mov       rdx,7FFB16D14020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       ecx,1A2D3
       mov       rdx,7FFB16D14020
       call      CORINFO_HELP_STRCNS
       lea       rcx,[rsi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 325
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendBytes(this.ByteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
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
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB17159498]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 125
```
```assembly
; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1A0D1C01048
       mov       r8,[r8]
       mov       rdx,1A0E1C011B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1A0D1C01048
       mov       r8,[r8]
       mov       rdx,1A0D1C013E0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rdx,1A0E1C011C0
       mov       rdx,[rdx]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rdi+rcx+10]
       mov       rax,1A0B1C01528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1A0E1C011C8
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rsi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       edx,27
       call      System.Text.StringBuilder.Append(Char)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 208
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       jne       short M02_L00
       mov       rax,1A0D1C01048
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M02_L01
       xor       ebx,ebx
       jmp       short M02_L02
M02_L01:
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rbx,[rsp+28]
M02_L02:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L03
       mov       rcx,[rsi+8]
       mov       edx,[rsi+1C]
       lea       eax,[r8+rdx]
       cmp       eax,[rdi+8]
       ja        short M02_L04
       mov       eax,[rcx+8]
       cmp       eax,r8d
       jb        short M02_L04
       cmp       eax,0
       jbe       near ptr M02_L05
       add       rcx,10
       mov       [rsp+20],rcx
       mov       rax,[rsp+20]
       movsxd    rcx,edx
       lea       rcx,[rbx+rcx*2]
       add       r8d,r8d
       mov       rdx,rax
       call      System.Buffer.Memmove(Byte*, Byte*, UIntPtr)
       xor       eax,eax
       mov       [rsp+20],rax
M02_L03:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L02
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,9B41
       mov       rdx,7FFB16D24020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       ecx,1A2D3
       mov       rdx,7FFB16D24020
       call      CORINFO_HELP_STRCNS
       lea       rcx,[rsi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 325
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendBytes(this.ByteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
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
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB17159498]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 125
```
```assembly
; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,203EA0A3060
       mov       r8,[r8]
       mov       rdx,203DA0A9170
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,203EA0A3060
       mov       r8,[r8]
       mov       rdx,203EA0A33F8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rdx,203DA0A9178
       mov       rdx,[rdx]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rdi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rdi+rcx+10]
       mov       rax,203EA0A1528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,203DA0A9180
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rsi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rsi
       mov       edx,27
       call      System.Text.StringBuilder.Append(Char)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 208
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       jne       short M02_L00
       mov       rax,203EA0A3060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M02_L01
       xor       ebx,ebx
       jmp       short M02_L02
M02_L01:
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rbx,[rsp+28]
M02_L02:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L03
       mov       rcx,[rsi+8]
       mov       edx,[rsi+1C]
       lea       eax,[r8+rdx]
       cmp       eax,[rdi+8]
       ja        short M02_L04
       mov       eax,[rcx+8]
       cmp       eax,r8d
       jb        short M02_L04
       cmp       eax,0
       jbe       near ptr M02_L05
       add       rcx,10
       mov       [rsp+20],rcx
       mov       rax,[rsp+20]
       movsxd    rcx,edx
       lea       rcx,[rbx+rcx*2]
       add       r8d,r8d
       mov       rdx,rax
       call      System.Buffer.Memmove(Byte*, Byte*, UIntPtr)
       xor       eax,eax
       mov       [rsp+20],rax
M02_L03:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L02
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,9B41
       mov       rdx,7FFB16D24020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       ecx,1A2D3
       mov       rdx,7FFB16D24020
       call      CORINFO_HELP_STRCNS
       lea       rcx,[rsi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 325
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue0()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
; 			for (var i = 0; i < this.StringArray.Length; i++)
; 			     ^^^^^^^^^
       xor       ebx,ebx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       cmp       dword ptr [rax+8],0
       jle       short M00_L01
; 				var testString = this.StringArray[i];
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       cmp       ebx,[rax+8]
       jae       short M00_L02
       movsxd    rcx,ebx
       mov       r8,[rax+rcx*8+10]
; 				sb.AppendKeyValue(testString, testString);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
       inc       ebx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       cmp       [rax+8],ebx
       jg        short M00_L00
M00_L01:
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB17169498]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 201
```
```assembly
; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14d,[rsp+80]
       mov       r8,20ACB463060
       mov       r8,[r8]
       mov       rdx,20ABB46DD90
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,20ACB463060
       mov       r8,[r8]
       mov       rdx,20ACB465820
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       r8,20ACB463060
       mov       r8,[r8]
       mov       rdx,20ABB46DC30
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,rsi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rcx,rsi
       mov       edx,3D
       call      System.Text.StringBuilder.Append(Char)
       cmp       ebp,0FFFFFFFF
       je        short M01_L00
       cmp       ebp,0FFFFFFFE
       jne       near ptr M01_L03
M01_L00:
       mov       rcx,rsi
       mov       edx,22
       call      System.Text.StringBuilder.Append(Char)
       xor       ebx,ebx
       mov       rcx,7FFB171C8B38
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       ebp,[rdi+8]
M01_L01:
       mov       r9,20ABB468370
       mov       rdx,[r9]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        short M01_L02
       mov       r9d,r15d
       sub       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      System.Text.StringBuilder.Append(Char)
       cmp       r15d,ebp
       jae       short M01_L07
       movsxd    rdx,r15d
       movzx     edx,word ptr [rdi+rdx*2+0C]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(Char)
       lea       ebx,[r15+1]
       jmp       short M01_L01
M01_L02:
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,22
       call      System.Text.StringBuilder.Append(Char)
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L04:
       cmp       r14d,0FFFFFFFF
       je        short M01_L05
       cmp       r14d,0FFFFFFFE
       jne       short M01_L06
M01_L05:
       mov       rdx,20ACB465730
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 409
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       jne       short M02_L00
       mov       rax,20ACB463060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M02_L01
       xor       ebx,ebx
       jmp       short M02_L02
M02_L01:
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rbx,[rsp+28]
M02_L02:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L03
       mov       rcx,[rsi+8]
       mov       edx,[rsi+1C]
       lea       eax,[r8+rdx]
       cmp       eax,[rdi+8]
       ja        short M02_L04
       mov       eax,[rcx+8]
       cmp       eax,r8d
       jb        short M02_L04
       cmp       eax,0
       jbe       near ptr M02_L05
       add       rcx,10
       mov       [rsp+20],rcx
       mov       rax,[rsp+20]
       movsxd    rcx,edx
       lea       rcx,[rbx+rcx*2]
       add       r8d,r8d
       mov       rdx,rax
       call      System.Buffer.Memmove(Byte*, Byte*, UIntPtr)
       xor       eax,eax
       mov       [rsp+20],rax
M02_L03:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L02
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,9B41
       mov       rdx,7FFB16D44020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       ecx,1A2D3
       mov       rdx,7FFB16D44020
       call      CORINFO_HELP_STRCNS
       lea       rcx,[rsi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 325
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue0()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
; 			for (var i = 0; i < this.StringArray.Length; i++)
; 			     ^^^^^^^^^
       xor       ebx,ebx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       cmp       dword ptr [rax+8],0
       jle       short M00_L01
; 				var testString = this.StringArray[i];
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       cmp       ebx,[rax+8]
       jae       short M00_L02
       movsxd    rcx,ebx
       mov       r8,[rax+rcx*8+10]
; 				sb.AppendKeyValue(testString, testString);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
       inc       ebx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       cmp       [rax+8],ebx
       jg        short M00_L00
M00_L01:
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB17169498]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 201
```
```assembly
; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14d,[rsp+80]
       mov       r8,22743513060
       mov       r8,[r8]
       mov       rdx,227235111B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,22743513060
       mov       r8,[r8]
       mov       rdx,227435223F8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       r8,22743513060
       mov       r8,[r8]
       mov       rdx,22723511058
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,rsi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rcx,rsi
       mov       edx,3D
       call      System.Text.StringBuilder.Append(Char)
       cmp       ebp,0FFFFFFFF
       je        short M01_L00
       cmp       ebp,0FFFFFFFE
       jne       near ptr M01_L03
M01_L00:
       mov       rcx,rsi
       mov       edx,22
       call      System.Text.StringBuilder.Append(Char)
       xor       ebx,ebx
       mov       rcx,7FFB171C8B38
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       ebp,[rdi+8]
M01_L01:
       mov       r9,2274351C7D8
       mov       rdx,[r9]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        short M01_L02
       mov       r9d,r15d
       sub       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      System.Text.StringBuilder.Append(Char)
       cmp       r15d,ebp
       jae       short M01_L07
       movsxd    rdx,r15d
       movzx     edx,word ptr [rdi+rdx*2+0C]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(Char)
       lea       ebx,[r15+1]
       jmp       short M01_L01
M01_L02:
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,22
       call      System.Text.StringBuilder.Append(Char)
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L04:
       cmp       r14d,0FFFFFFFF
       je        short M01_L05
       cmp       r14d,0FFFFFFFE
       jne       short M01_L06
M01_L05:
       mov       rdx,22743522308
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 409
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       jne       short M02_L00
       mov       rax,22743513060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M02_L01
       xor       ebx,ebx
       jmp       short M02_L02
M02_L01:
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rbx,[rsp+28]
M02_L02:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L03
       mov       rcx,[rsi+8]
       mov       edx,[rsi+1C]
       lea       eax,[r8+rdx]
       cmp       eax,[rdi+8]
       ja        short M02_L04
       mov       eax,[rcx+8]
       cmp       eax,r8d
       jb        short M02_L04
       cmp       eax,0
       jbe       near ptr M02_L05
       add       rcx,10
       mov       [rsp+20],rcx
       mov       rax,[rsp+20]
       movsxd    rcx,edx
       lea       rcx,[rbx+rcx*2]
       add       r8d,r8d
       mov       rdx,rax
       call      System.Buffer.Memmove(Byte*, Byte*, UIntPtr)
       xor       eax,eax
       mov       [rsp+20],rax
M02_L03:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L02
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,9B41
       mov       rdx,7FFB16D44020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       ecx,1A2D3
       mov       rdx,7FFB16D44020
       call      CORINFO_HELP_STRCNS
       lea       rcx,[rsi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 325
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue0()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
; 			for (var i = 0; i < this.StringArray.Length; i++)
; 			     ^^^^^^^^^
       xor       ebx,ebx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       cmp       dword ptr [rax+8],0
       jle       short M00_L01
; 				var testString = this.StringArray[i];
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       cmp       ebx,[rax+8]
       jae       short M00_L02
       movsxd    rcx,ebx
       mov       r8,[rax+rcx*8+10]
; 				sb.AppendKeyValue(testString, testString);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
       inc       ebx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       cmp       [rax+8],ebx
       jg        short M00_L00
M00_L01:
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB17149498]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 201
```
```assembly
; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14d,[rsp+80]
       mov       r8,2430BC53060
       mov       r8,[r8]
       mov       rdx,2430BC53608
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,2430BC53060
       mov       r8,[r8]
       mov       rdx,2433BC5FFA8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       r8,2430BC53060
       mov       r8,[r8]
       mov       rdx,2430BC534A8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,rsi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rcx,rsi
       mov       edx,3D
       call      System.Text.StringBuilder.Append(Char)
       cmp       ebp,0FFFFFFFF
       je        short M01_L00
       cmp       ebp,0FFFFFFFE
       jne       near ptr M01_L03
M01_L00:
       mov       rcx,rsi
       mov       edx,22
       call      System.Text.StringBuilder.Append(Char)
       xor       ebx,ebx
       mov       rcx,7FFB171A8B38
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       ebp,[rdi+8]
M01_L01:
       mov       r9,2433BC5A388
       mov       rdx,[r9]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        short M01_L02
       mov       r9d,r15d
       sub       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      System.Text.StringBuilder.Append(Char)
       cmp       r15d,ebp
       jae       short M01_L07
       movsxd    rdx,r15d
       movzx     edx,word ptr [rdi+rdx*2+0C]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(Char)
       lea       ebx,[r15+1]
       jmp       short M01_L01
M01_L02:
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,22
       call      System.Text.StringBuilder.Append(Char)
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L04:
       cmp       r14d,0FFFFFFFF
       je        short M01_L05
       cmp       r14d,0FFFFFFFE
       jne       short M01_L06
M01_L05:
       mov       rdx,2433BC5FEB8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 409
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       jne       short M02_L00
       mov       rax,2430BC53060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M02_L01
       xor       ebx,ebx
       jmp       short M02_L02
M02_L01:
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rbx,[rsp+28]
M02_L02:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L03
       mov       rcx,[rsi+8]
       mov       edx,[rsi+1C]
       lea       eax,[r8+rdx]
       cmp       eax,[rdi+8]
       ja        short M02_L04
       mov       eax,[rcx+8]
       cmp       eax,r8d
       jb        short M02_L04
       cmp       eax,0
       jbe       near ptr M02_L05
       add       rcx,10
       mov       [rsp+20],rcx
       mov       rax,[rsp+20]
       movsxd    rcx,edx
       lea       rcx,[rbx+rcx*2]
       add       r8d,r8d
       mov       rdx,rax
       call      System.Buffer.Memmove(Byte*, Byte*, UIntPtr)
       xor       eax,eax
       mov       [rsp+20],rax
M02_L03:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L02
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,9B41
       mov       rdx,7FFB16D24020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       ecx,1A2D3
       mov       rdx,7FFB16D24020
       call      CORINFO_HELP_STRCNS
       lea       rcx,[rsi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 325
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue0()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
; 			for (var i = 0; i < this.StringArray.Length; i++)
; 			     ^^^^^^^^^
       xor       ebx,ebx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       cmp       dword ptr [rax+8],0
       jle       short M00_L01
; 				var testString = this.StringArray[i];
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       cmp       ebx,[rax+8]
       jae       short M00_L02
       movsxd    rcx,ebx
       mov       r8,[rax+rcx*8+10]
; 				sb.AppendKeyValue(testString, testString);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
       inc       ebx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       cmp       [rax+8],ebx
       jg        short M00_L00
M00_L01:
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB17159498]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 201
```
```assembly
; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14d,[rsp+80]
       mov       r8,1FC12E41048
       mov       r8,[r8]
       mov       rdx,1FC02E411B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1FC12E41048
       mov       r8,[r8]
       mov       rdx,1FC12E43808
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       r8,1FC12E41048
       mov       r8,[r8]
       mov       rdx,1FC02E41058
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,rsi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rcx,rsi
       mov       edx,3D
       call      System.Text.StringBuilder.Append(Char)
       cmp       ebp,0FFFFFFFF
       je        short M01_L00
       cmp       ebp,0FFFFFFFE
       jne       near ptr M01_L03
M01_L00:
       mov       rcx,rsi
       mov       edx,22
       call      System.Text.StringBuilder.Append(Char)
       xor       ebx,ebx
       mov       rcx,7FFB171B8B38
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       ebp,[rdi+8]
M01_L01:
       mov       r9,1FBF2E4A388
       mov       rdx,[r9]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        short M01_L02
       mov       r9d,r15d
       sub       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      System.Text.StringBuilder.Append(Char)
       cmp       r15d,ebp
       jae       short M01_L07
       movsxd    rdx,r15d
       movzx     edx,word ptr [rdi+rdx*2+0C]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(Char)
       lea       ebx,[r15+1]
       jmp       short M01_L01
M01_L02:
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,22
       call      System.Text.StringBuilder.Append(Char)
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L04:
       cmp       r14d,0FFFFFFFF
       je        short M01_L05
       cmp       r14d,0FFFFFFFE
       jne       short M01_L06
M01_L05:
       mov       rdx,1FC12E43718
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 409
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       jne       short M02_L00
       mov       rax,1FC12E41048
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M02_L01
       xor       ebx,ebx
       jmp       short M02_L02
M02_L01:
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rbx,[rsp+28]
M02_L02:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L03
       mov       rcx,[rsi+8]
       mov       edx,[rsi+1C]
       lea       eax,[r8+rdx]
       cmp       eax,[rdi+8]
       ja        short M02_L04
       mov       eax,[rcx+8]
       cmp       eax,r8d
       jb        short M02_L04
       cmp       eax,0
       jbe       near ptr M02_L05
       add       rcx,10
       mov       [rsp+20],rcx
       mov       rax,[rsp+20]
       movsxd    rcx,edx
       lea       rcx,[rbx+rcx*2]
       add       r8d,r8d
       mov       rdx,rax
       call      System.Buffer.Memmove(Byte*, Byte*, UIntPtr)
       xor       eax,eax
       mov       [rsp+20],rax
M02_L03:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L02
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,9B41
       mov       rdx,7FFB16D34020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       ecx,1A2D3
       mov       rdx,7FFB16D34020
       call      CORINFO_HELP_STRCNS
       lea       rcx,[rsi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 325
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue0()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
; 			for (var i = 0; i < this.StringArray.Length; i++)
; 			     ^^^^^^^^^
       xor       ebx,ebx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       cmp       dword ptr [rax+8],0
       jle       short M00_L01
; 				var testString = this.StringArray[i];
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       cmp       ebx,[rax+8]
       jae       short M00_L02
       movsxd    rcx,ebx
       mov       r8,[rax+rcx*8+10]
; 				sb.AppendKeyValue(testString, testString);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
       inc       ebx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       cmp       [rax+8],ebx
       jg        short M00_L00
M00_L01:
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB17179498]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 201
```
```assembly
; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14d,[rsp+80]
       mov       r8,22C28813060
       mov       r8,[r8]
       mov       rdx,22C28813608
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,22C28813060
       mov       r8,[r8]
       mov       rdx,22C188113B8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       r8,22C28813060
       mov       r8,[r8]
       mov       rdx,22C288134A8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,rsi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rcx,rsi
       mov       edx,3D
       call      System.Text.StringBuilder.Append(Char)
       cmp       ebp,0FFFFFFFF
       je        short M01_L00
       cmp       ebp,0FFFFFFFE
       jne       near ptr M01_L03
M01_L00:
       mov       rcx,rsi
       mov       edx,22
       call      System.Text.StringBuilder.Append(Char)
       xor       ebx,ebx
       mov       rcx,7FFB171D8B38
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       ebp,[rdi+8]
M01_L01:
       mov       r9,22C3881A388
       mov       rdx,[r9]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        short M01_L02
       mov       r9d,r15d
       sub       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      System.Text.StringBuilder.Append(Char)
       cmp       r15d,ebp
       jae       short M01_L07
       movsxd    rdx,r15d
       movzx     edx,word ptr [rdi+rdx*2+0C]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(Char)
       lea       ebx,[r15+1]
       jmp       short M01_L01
M01_L02:
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,22
       call      System.Text.StringBuilder.Append(Char)
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L04:
       cmp       r14d,0FFFFFFFF
       je        short M01_L05
       cmp       r14d,0FFFFFFFE
       jne       short M01_L06
M01_L05:
       mov       rdx,22C188112C8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 409
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       jne       short M02_L00
       mov       rax,22C28813060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M02_L01
       xor       ebx,ebx
       jmp       short M02_L02
M02_L01:
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rbx,[rsp+28]
M02_L02:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L03
       mov       rcx,[rsi+8]
       mov       edx,[rsi+1C]
       lea       eax,[r8+rdx]
       cmp       eax,[rdi+8]
       ja        short M02_L04
       mov       eax,[rcx+8]
       cmp       eax,r8d
       jb        short M02_L04
       cmp       eax,0
       jbe       near ptr M02_L05
       add       rcx,10
       mov       [rsp+20],rcx
       mov       rax,[rsp+20]
       movsxd    rcx,edx
       lea       rcx,[rbx+rcx*2]
       add       r8d,r8d
       mov       rdx,rax
       call      System.Buffer.Memmove(Byte*, Byte*, UIntPtr)
       xor       eax,eax
       mov       [rsp+20],rax
M02_L03:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L02
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,9B41
       mov       rdx,7FFB16D54020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       ecx,1A2D3
       mov       rdx,7FFB16D54020
       call      CORINFO_HELP_STRCNS
       lea       rcx,[rsi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 325
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue0()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
; 			for (var i = 0; i < this.StringArray.Length; i++)
; 			     ^^^^^^^^^
       xor       ebx,ebx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       cmp       dword ptr [rax+8],0
       jle       short M00_L01
; 				var testString = this.StringArray[i];
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       cmp       ebx,[rax+8]
       jae       short M00_L02
       movsxd    rcx,ebx
       mov       r8,[rax+rcx*8+10]
; 				sb.AppendKeyValue(testString, testString);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
       inc       ebx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       cmp       [rax+8],ebx
       jg        short M00_L00
M00_L01:
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB17179498]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 201
```
```assembly
; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14d,[rsp+80]
       mov       r8,192D3493060
       mov       r8,[r8]
       mov       rdx,192B34911B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,192D3493060
       mov       r8,[r8]
       mov       rdx,192E34913B8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       r8,192D3493060
       mov       r8,[r8]
       mov       rdx,192B3491058
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,rsi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rcx,rsi
       mov       edx,3D
       call      System.Text.StringBuilder.Append(Char)
       cmp       ebp,0FFFFFFFF
       je        short M01_L00
       cmp       ebp,0FFFFFFFE
       jne       near ptr M01_L03
M01_L00:
       mov       rcx,rsi
       mov       edx,22
       call      System.Text.StringBuilder.Append(Char)
       xor       ebx,ebx
       mov       rcx,7FFB171D8B38
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       ebp,[rdi+8]
M01_L01:
       mov       r9,192C3498370
       mov       rdx,[r9]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        short M01_L02
       mov       r9d,r15d
       sub       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      System.Text.StringBuilder.Append(Char)
       cmp       r15d,ebp
       jae       short M01_L07
       movsxd    rdx,r15d
       movzx     edx,word ptr [rdi+rdx*2+0C]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(Char)
       lea       ebx,[r15+1]
       jmp       short M01_L01
M01_L02:
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,22
       call      System.Text.StringBuilder.Append(Char)
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L04:
       cmp       r14d,0FFFFFFFF
       je        short M01_L05
       cmp       r14d,0FFFFFFFE
       jne       short M01_L06
M01_L05:
       mov       rdx,192E34912C8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 409
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       jne       short M02_L00
       mov       rax,192D3493060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M02_L01
       xor       ebx,ebx
       jmp       short M02_L02
M02_L01:
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rbx,[rsp+28]
M02_L02:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L03
       mov       rcx,[rsi+8]
       mov       edx,[rsi+1C]
       lea       eax,[r8+rdx]
       cmp       eax,[rdi+8]
       ja        short M02_L04
       mov       eax,[rcx+8]
       cmp       eax,r8d
       jb        short M02_L04
       cmp       eax,0
       jbe       near ptr M02_L05
       add       rcx,10
       mov       [rsp+20],rcx
       mov       rax,[rsp+20]
       movsxd    rcx,edx
       lea       rcx,[rbx+rcx*2]
       add       r8d,r8d
       mov       rdx,rax
       call      System.Buffer.Memmove(Byte*, Byte*, UIntPtr)
       xor       eax,eax
       mov       [rsp+20],rax
M02_L03:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L02
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,9B41
       mov       rdx,7FFB16D54020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       ecx,1A2D3
       mov       rdx,7FFB16D54020
       call      CORINFO_HELP_STRCNS
       lea       rcx,[rsi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 325
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue0()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
; 			for (var i = 0; i < this.StringArray.Length; i++)
; 			     ^^^^^^^^^
       xor       ebx,ebx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       cmp       dword ptr [rax+8],0
       jle       short M00_L01
; 				var testString = this.StringArray[i];
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       cmp       ebx,[rax+8]
       jae       short M00_L02
       movsxd    rcx,ebx
       mov       r8,[rax+rcx*8+10]
; 				sb.AppendKeyValue(testString, testString);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
       inc       ebx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       cmp       [rax+8],ebx
       jg        short M00_L00
M00_L01:
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB17169498]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 201
```
```assembly
; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14d,[rsp+80]
       mov       r8,20525E51048
       mov       r8,[r8]
       mov       rdx,20505E53A08
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,20525E51048
       mov       r8,[r8]
       mov       rdx,20505E533D0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       r8,20525E51048
       mov       r8,[r8]
       mov       rdx,20505E538A8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,rsi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rcx,rsi
       mov       edx,3D
       call      System.Text.StringBuilder.Append(Char)
       cmp       ebp,0FFFFFFFF
       je        short M01_L00
       cmp       ebp,0FFFFFFFE
       jne       near ptr M01_L03
M01_L00:
       mov       rcx,rsi
       mov       edx,22
       call      System.Text.StringBuilder.Append(Char)
       xor       ebx,ebx
       mov       rcx,7FFB171C8B38
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       ebp,[rdi+8]
M01_L01:
       mov       r9,20525E5A7C0
       mov       rdx,[r9]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        short M01_L02
       mov       r9d,r15d
       sub       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      System.Text.StringBuilder.Append(Char)
       cmp       r15d,ebp
       jae       short M01_L07
       movsxd    rdx,r15d
       movzx     edx,word ptr [rdi+rdx*2+0C]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(Char)
       lea       ebx,[r15+1]
       jmp       short M01_L01
M01_L02:
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,22
       call      System.Text.StringBuilder.Append(Char)
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L04:
       cmp       r14d,0FFFFFFFF
       je        short M01_L05
       cmp       r14d,0FFFFFFFE
       jne       short M01_L06
M01_L05:
       mov       rdx,20505E532E0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 409
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       jne       short M02_L00
       mov       rax,20525E51048
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M02_L01
       xor       ebx,ebx
       jmp       short M02_L02
M02_L01:
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rbx,[rsp+28]
M02_L02:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L03
       mov       rcx,[rsi+8]
       mov       edx,[rsi+1C]
       lea       eax,[r8+rdx]
       cmp       eax,[rdi+8]
       ja        short M02_L04
       mov       eax,[rcx+8]
       cmp       eax,r8d
       jb        short M02_L04
       cmp       eax,0
       jbe       near ptr M02_L05
       add       rcx,10
       mov       [rsp+20],rcx
       mov       rax,[rsp+20]
       movsxd    rcx,edx
       lea       rcx,[rbx+rcx*2]
       add       r8d,r8d
       mov       rdx,rax
       call      System.Buffer.Memmove(Byte*, Byte*, UIntPtr)
       xor       eax,eax
       mov       [rsp+20],rax
M02_L03:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L02
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,9B41
       mov       rdx,7FFB16D44020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       ecx,1A2D3
       mov       rdx,7FFB16D44020
       call      CORINFO_HELP_STRCNS
       lea       rcx,[rsi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 325
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue0()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
; 			for (var i = 0; i < this.StringArray.Length; i++)
; 			     ^^^^^^^^^
       xor       ebx,ebx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       cmp       dword ptr [rax+8],0
       jle       short M00_L01
; 				var testString = this.StringArray[i];
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       cmp       ebx,[rax+8]
       jae       short M00_L02
       movsxd    rcx,ebx
       mov       r8,[rax+rcx*8+10]
; 				sb.AppendKeyValue(testString, testString);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
       inc       ebx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       cmp       [rax+8],ebx
       jg        short M00_L00
M00_L01:
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB17179498]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 201
```
```assembly
; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14d,[rsp+80]
       mov       r8,220CFD73060
       mov       r8,[r8]
       mov       rdx,220CFDB2678
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,220CFD73060
       mov       r8,[r8]
       mov       rdx,220CFD73808
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       r8,220CFD73060
       mov       r8,[r8]
       mov       rdx,220CFDB2518
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,rsi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rcx,rsi
       mov       edx,3D
       call      System.Text.StringBuilder.Append(Char)
       cmp       ebp,0FFFFFFFF
       je        short M01_L00
       cmp       ebp,0FFFFFFFE
       jne       near ptr M01_L03
M01_L00:
       mov       rcx,rsi
       mov       edx,22
       call      System.Text.StringBuilder.Append(Char)
       xor       ebx,ebx
       mov       rcx,7FFB171D8B38
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       ebp,[rdi+8]
M01_L01:
       mov       r9,220EFD7A388
       mov       rdx,[r9]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        short M01_L02
       mov       r9d,r15d
       sub       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      System.Text.StringBuilder.Append(Char)
       cmp       r15d,ebp
       jae       short M01_L07
       movsxd    rdx,r15d
       movzx     edx,word ptr [rdi+rdx*2+0C]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(Char)
       lea       ebx,[r15+1]
       jmp       short M01_L01
M01_L02:
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,22
       call      System.Text.StringBuilder.Append(Char)
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L04:
       cmp       r14d,0FFFFFFFF
       je        short M01_L05
       cmp       r14d,0FFFFFFFE
       jne       short M01_L06
M01_L05:
       mov       rdx,220CFD73718
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 409
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       jne       short M02_L00
       mov       rax,220CFD73060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M02_L01
       xor       ebx,ebx
       jmp       short M02_L02
M02_L01:
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rbx,[rsp+28]
M02_L02:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L03
       mov       rcx,[rsi+8]
       mov       edx,[rsi+1C]
       lea       eax,[r8+rdx]
       cmp       eax,[rdi+8]
       ja        short M02_L04
       mov       eax,[rcx+8]
       cmp       eax,r8d
       jb        short M02_L04
       cmp       eax,0
       jbe       near ptr M02_L05
       add       rcx,10
       mov       [rsp+20],rcx
       mov       rax,[rsp+20]
       movsxd    rcx,edx
       lea       rcx,[rbx+rcx*2]
       add       r8d,r8d
       mov       rdx,rax
       call      System.Buffer.Memmove(Byte*, Byte*, UIntPtr)
       xor       eax,eax
       mov       [rsp+20],rax
M02_L03:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L02
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,9B41
       mov       rdx,7FFB16D54020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       ecx,1A2D3
       mov       rdx,7FFB16D54020
       call      CORINFO_HELP_STRCNS
       lea       rcx,[rsi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 325
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue0()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
; 			for (var i = 0; i < this.StringArray.Length; i++)
; 			     ^^^^^^^^^
       xor       ebx,ebx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       cmp       dword ptr [rax+8],0
       jle       short M00_L01
; 				var testString = this.StringArray[i];
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       cmp       ebx,[rax+8]
       jae       short M00_L02
       movsxd    rcx,ebx
       mov       r8,[rax+rcx*8+10]
; 				sb.AppendKeyValue(testString, testString);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
       inc       ebx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       cmp       [rax+8],ebx
       jg        short M00_L00
M00_L01:
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB17159498]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 201
```
```assembly
; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, dotNetTips.Spargine.Core.Tristate, dotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14d,[rsp+80]
       mov       r8,232535F3060
       mov       r8,[r8]
       mov       rdx,2327366E1F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,232535F3060
       mov       r8,[r8]
       mov       rdx,232635FFFA8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       r8,232535F3060
       mov       r8,[r8]
       mov       rdx,2327366E090
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,rsi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       rcx,rsi
       mov       edx,3D
       call      System.Text.StringBuilder.Append(Char)
       cmp       ebp,0FFFFFFFF
       je        short M01_L00
       cmp       ebp,0FFFFFFFE
       jne       near ptr M01_L03
M01_L00:
       mov       rcx,rsi
       mov       edx,22
       call      System.Text.StringBuilder.Append(Char)
       xor       ebx,ebx
       mov       rcx,7FFB171B8B38
       mov       edx,28
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       ebp,[rdi+8]
M01_L01:
       mov       r9,232635FA388
       mov       rdx,[r9]
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rdi
       mov       r8d,ebx
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       mov       r15d,eax
       test      r15d,r15d
       jl        short M01_L02
       mov       r9d,r15d
       sub       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      System.Text.StringBuilder.Append(Char)
       cmp       r15d,ebp
       jae       short M01_L07
       movsxd    rdx,r15d
       movzx     edx,word ptr [rdi+rdx*2+0C]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(Char)
       lea       ebx,[r15+1]
       jmp       short M01_L01
M01_L02:
       mov       r9d,ebp
       sub       r9d,ebx
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,22
       call      System.Text.StringBuilder.Append(Char)
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.StringBuilder.Append(System.String)
M01_L04:
       cmp       r14d,0FFFFFFFF
       je        short M01_L05
       cmp       r14d,0FFFFFFFE
       jne       short M01_L06
M01_L05:
       mov       rdx,232635FFEB8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(System.String)
M01_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 409
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       jne       short M02_L00
       mov       rax,232535F3060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M02_L01
       xor       ebx,ebx
       jmp       short M02_L02
M02_L01:
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rbx,[rsp+28]
M02_L02:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L03
       mov       rcx,[rsi+8]
       mov       edx,[rsi+1C]
       lea       eax,[r8+rdx]
       cmp       eax,[rdi+8]
       ja        short M02_L04
       mov       eax,[rcx+8]
       cmp       eax,r8d
       jb        short M02_L04
       cmp       eax,0
       jbe       near ptr M02_L05
       add       rcx,10
       mov       [rsp+20],rcx
       mov       rax,[rsp+20]
       movsxd    rcx,edx
       lea       rcx,[rbx+rcx*2]
       add       r8d,r8d
       mov       rdx,rax
       call      System.Buffer.Memmove(Byte*, Byte*, UIntPtr)
       xor       eax,eax
       mov       [rsp+20],rax
M02_L03:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L02
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,9B41
       mov       rdx,7FFB16D34020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       ecx,1A2D3
       mov       rdx,7FFB16D34020
       call      CORINFO_HELP_STRCNS
       lea       rcx,[rsi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 325
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
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
       mov       rcx,1B9ED1D12C8
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB17169498]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+8]
       mov       rdx,1BA1D1D3608
       mov       rdx,[rdx]
       mov       r8,1BA1D1D3060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1BA1D1D3060
       mov       r8,[r8]
       mov       rdx,1BA1D1D3610
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 218
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       jne       short M02_L00
       mov       rax,1BA1D1D3060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M02_L01
       xor       ebx,ebx
       jmp       short M02_L02
M02_L01:
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rbx,[rsp+28]
M02_L02:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L03
       mov       rcx,[rsi+8]
       mov       edx,[rsi+1C]
       lea       eax,[r8+rdx]
       cmp       eax,[rdi+8]
       ja        short M02_L04
       mov       eax,[rcx+8]
       cmp       eax,r8d
       jb        short M02_L04
       cmp       eax,0
       jbe       near ptr M02_L05
       add       rcx,10
       mov       [rsp+20],rcx
       mov       rax,[rsp+20]
       movsxd    rcx,edx
       lea       rcx,[rbx+rcx*2]
       add       r8d,r8d
       mov       rdx,rax
       call      System.Buffer.Memmove(Byte*, Byte*, UIntPtr)
       xor       eax,eax
       mov       [rsp+20],rax
M02_L03:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L02
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,9B41
       mov       rdx,7FFB16D34020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       ecx,1A2D3
       mov       rdx,7FFB16D34020
       call      CORINFO_HELP_STRCNS
       lea       rcx,[rsi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 325
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
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
       mov       rcx,150BFD12308
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB17159498]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+8]
       mov       rdx,1509FD011B8
       mov       rdx,[rdx]
       mov       r8,150BFD03060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,150BFD03060
       mov       r8,[r8]
       mov       rdx,1509FD011C0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 218
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       jne       short M02_L00
       mov       rax,150BFD03060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M02_L01
       xor       ebx,ebx
       jmp       short M02_L02
M02_L01:
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rbx,[rsp+28]
M02_L02:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L03
       mov       rcx,[rsi+8]
       mov       edx,[rsi+1C]
       lea       eax,[r8+rdx]
       cmp       eax,[rdi+8]
       ja        short M02_L04
       mov       eax,[rcx+8]
       cmp       eax,r8d
       jb        short M02_L04
       cmp       eax,0
       jbe       near ptr M02_L05
       add       rcx,10
       mov       [rsp+20],rcx
       mov       rax,[rsp+20]
       movsxd    rcx,edx
       lea       rcx,[rbx+rcx*2]
       add       r8d,r8d
       mov       rdx,rax
       call      System.Buffer.Memmove(Byte*, Byte*, UIntPtr)
       xor       eax,eax
       mov       [rsp+20],rax
M02_L03:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L02
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,9B41
       mov       rdx,7FFB16D24020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       ecx,1A2D3
       mov       rdx,7FFB16D24020
       call      CORINFO_HELP_STRCNS
       lea       rcx,[rsi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 325
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
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
       mov       rcx,23499038338
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB17179498]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+8]
       mov       rdx,2347903B188
       mov       rdx,[rdx]
       mov       r8,23499031048
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,23499031048
       mov       r8,[r8]
       mov       rdx,2347903B190
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 218
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       jne       short M02_L00
       mov       rax,23499031048
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M02_L01
       xor       ebx,ebx
       jmp       short M02_L02
M02_L01:
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rbx,[rsp+28]
M02_L02:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L03
       mov       rcx,[rsi+8]
       mov       edx,[rsi+1C]
       lea       eax,[r8+rdx]
       cmp       eax,[rdi+8]
       ja        short M02_L04
       mov       eax,[rcx+8]
       cmp       eax,r8d
       jb        short M02_L04
       cmp       eax,0
       jbe       near ptr M02_L05
       add       rcx,10
       mov       [rsp+20],rcx
       mov       rax,[rsp+20]
       movsxd    rcx,edx
       lea       rcx,[rbx+rcx*2]
       add       r8d,r8d
       mov       rdx,rax
       call      System.Buffer.Memmove(Byte*, Byte*, UIntPtr)
       xor       eax,eax
       mov       [rsp+20],rax
M02_L03:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L02
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,9B41
       mov       rdx,7FFB16D44020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       ecx,1A2D3
       mov       rdx,7FFB16D44020
       call      CORINFO_HELP_STRCNS
       lea       rcx,[rsi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 325
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
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
       mov       rcx,1CDB8A212C8
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB17169498]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+8]
       mov       rdx,1CD98A2DD90
       mov       rdx,[rdx]
       mov       r8,1CDA8A23060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1CDA8A23060
       mov       r8,[r8]
       mov       rdx,1CD98A2DD98
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 218
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       jne       short M02_L00
       mov       rax,1CDA8A23060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M02_L01
       xor       ebx,ebx
       jmp       short M02_L02
M02_L01:
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rbx,[rsp+28]
M02_L02:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L03
       mov       rcx,[rsi+8]
       mov       edx,[rsi+1C]
       lea       eax,[r8+rdx]
       cmp       eax,[rdi+8]
       ja        short M02_L04
       mov       eax,[rcx+8]
       cmp       eax,r8d
       jb        short M02_L04
       cmp       eax,0
       jbe       near ptr M02_L05
       add       rcx,10
       mov       [rsp+20],rcx
       mov       rax,[rsp+20]
       movsxd    rcx,edx
       lea       rcx,[rbx+rcx*2]
       add       r8d,r8d
       mov       rdx,rax
       call      System.Buffer.Memmove(Byte*, Byte*, UIntPtr)
       xor       eax,eax
       mov       [rsp+20],rax
M02_L03:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L02
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,9B41
       mov       rdx,7FFB16D34020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       ecx,1A2D3
       mov       rdx,7FFB16D34020
       call      CORINFO_HELP_STRCNS
       lea       rcx,[rsi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 325
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
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
       mov       rcx,24F7E1CD6E8
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB17159498]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+8]
       mov       rdx,24F6E1C11B8
       mov       rdx,[rdx]
       mov       r8,24F7E1C3060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,24F7E1C3060
       mov       r8,[r8]
       mov       rdx,24F6E1C11C0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 218
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       jne       short M02_L00
       mov       rax,24F7E1C3060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M02_L01
       xor       ebx,ebx
       jmp       short M02_L02
M02_L01:
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rbx,[rsp+28]
M02_L02:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L03
       mov       rcx,[rsi+8]
       mov       edx,[rsi+1C]
       lea       eax,[r8+rdx]
       cmp       eax,[rdi+8]
       ja        short M02_L04
       mov       eax,[rcx+8]
       cmp       eax,r8d
       jb        short M02_L04
       cmp       eax,0
       jbe       near ptr M02_L05
       add       rcx,10
       mov       [rsp+20],rcx
       mov       rax,[rsp+20]
       movsxd    rcx,edx
       lea       rcx,[rbx+rcx*2]
       add       r8d,r8d
       mov       rdx,rax
       call      System.Buffer.Memmove(Byte*, Byte*, UIntPtr)
       xor       eax,eax
       mov       [rsp+20],rax
M02_L03:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L02
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,9B41
       mov       rdx,7FFB16D24020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       ecx,1A2D3
       mov       rdx,7FFB16D24020
       call      CORINFO_HELP_STRCNS
       lea       rcx,[rsi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 325
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
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
       mov       rcx,20E7C642308
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB17169498]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+8]
       mov       rdx,20E7C642A30
       mov       rdx,[rdx]
       mov       r8,20E7C633060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,20E7C633060
       mov       r8,[r8]
       mov       rdx,20E7C642A38
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 218
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       jne       short M02_L00
       mov       rax,20E7C633060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M02_L01
       xor       ebx,ebx
       jmp       short M02_L02
M02_L01:
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rbx,[rsp+28]
M02_L02:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L03
       mov       rcx,[rsi+8]
       mov       edx,[rsi+1C]
       lea       eax,[r8+rdx]
       cmp       eax,[rdi+8]
       ja        short M02_L04
       mov       eax,[rcx+8]
       cmp       eax,r8d
       jb        short M02_L04
       cmp       eax,0
       jbe       near ptr M02_L05
       add       rcx,10
       mov       [rsp+20],rcx
       mov       rax,[rsp+20]
       movsxd    rcx,edx
       lea       rcx,[rbx+rcx*2]
       add       r8d,r8d
       mov       rdx,rax
       call      System.Buffer.Memmove(Byte*, Byte*, UIntPtr)
       xor       eax,eax
       mov       [rsp+20],rax
M02_L03:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L02
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,9B41
       mov       rdx,7FFB16D34020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       ecx,1A2D3
       mov       rdx,7FFB16D34020
       call      CORINFO_HELP_STRCNS
       lea       rcx,[rsi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 325
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
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
       mov       rcx,16B892212C8
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB17189498]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+8]
       mov       rdx,16B992211B8
       mov       rdx,[rdx]
       mov       r8,16BA9223060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,16BA9223060
       mov       r8,[r8]
       mov       rdx,16B992211C0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 218
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       jne       short M02_L00
       mov       rax,16BA9223060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M02_L01
       xor       ebx,ebx
       jmp       short M02_L02
M02_L01:
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rbx,[rsp+28]
M02_L02:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L03
       mov       rcx,[rsi+8]
       mov       edx,[rsi+1C]
       lea       eax,[r8+rdx]
       cmp       eax,[rdi+8]
       ja        short M02_L04
       mov       eax,[rcx+8]
       cmp       eax,r8d
       jb        short M02_L04
       cmp       eax,0
       jbe       near ptr M02_L05
       add       rcx,10
       mov       [rsp+20],rcx
       mov       rax,[rsp+20]
       movsxd    rcx,edx
       lea       rcx,[rbx+rcx*2]
       add       r8d,r8d
       mov       rdx,rax
       call      System.Buffer.Memmove(Byte*, Byte*, UIntPtr)
       xor       eax,eax
       mov       [rsp+20],rax
M02_L03:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L02
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,9B41
       mov       rdx,7FFB16D54020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       ecx,1A2D3
       mov       rdx,7FFB16D54020
       call      CORINFO_HELP_STRCNS
       lea       rcx,[rsi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 325
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
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
       mov       rcx,17E363312C8
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB17179498]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+8]
       mov       rdx,17E563421F8
       mov       rdx,[rdx]
       mov       r8,17E56333060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,17E56333060
       mov       r8,[r8]
       mov       rdx,17E56342200
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 218
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       jne       short M02_L00
       mov       rax,17E56333060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M02_L01
       xor       ebx,ebx
       jmp       short M02_L02
M02_L01:
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rbx,[rsp+28]
M02_L02:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L03
       mov       rcx,[rsi+8]
       mov       edx,[rsi+1C]
       lea       eax,[r8+rdx]
       cmp       eax,[rdi+8]
       ja        short M02_L04
       mov       eax,[rcx+8]
       cmp       eax,r8d
       jb        short M02_L04
       cmp       eax,0
       jbe       near ptr M02_L05
       add       rcx,10
       mov       [rsp+20],rcx
       mov       rax,[rsp+20]
       movsxd    rcx,edx
       lea       rcx,[rbx+rcx*2]
       add       r8d,r8d
       mov       rdx,rax
       call      System.Buffer.Memmove(Byte*, Byte*, UIntPtr)
       xor       eax,eax
       mov       [rsp+20],rax
M02_L03:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L02
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,9B41
       mov       rdx,7FFB16D44020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       ecx,1A2D3
       mov       rdx,7FFB16D44020
       call      CORINFO_HELP_STRCNS
       lea       rcx,[rsi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 325
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
; 			var sb = new StringBuilder();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			sb.AppendValues(ControlChars.DefaultSeparator, this.StringArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(sb.ToString());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
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
       mov       rcx,29C322F12C8
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB17189498]
       cmp       [rsi],esi
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+8]
       mov       rdx,29C222F5620
       mov       rdx,[rdx]
       mov       r8,29C222F3060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,29C222F3060
       mov       r8,[r8]
       mov       rdx,29C222F5628
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       r14,[rbp+8]
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       mov       [rbx+18],rdx
       mov       [rsp+20],rbx
       mov       rdx,r14
       mov       r8,rsi
       mov       r9,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<!!0>, System.Action`1<!!0>)
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 218
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       jne       short M02_L00
       mov       rax,29C222F3060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M02_L01
       xor       ebx,ebx
       jmp       short M02_L02
M02_L01:
       lea       rcx,[rdi+0C]
       mov       [rsp+28],rcx
       mov       rbx,[rsp+28]
M02_L02:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L03
       mov       rcx,[rsi+8]
       mov       edx,[rsi+1C]
       lea       eax,[r8+rdx]
       cmp       eax,[rdi+8]
       ja        short M02_L04
       mov       eax,[rcx+8]
       cmp       eax,r8d
       jb        short M02_L04
       cmp       eax,0
       jbe       near ptr M02_L05
       add       rcx,10
       mov       [rsp+20],rcx
       mov       rax,[rsp+20]
       movsxd    rcx,edx
       lea       rcx,[rbx+rcx*2]
       add       r8d,r8d
       mov       rdx,rax
       call      System.Buffer.Memmove(Byte*, Byte*, UIntPtr)
       xor       eax,eax
       mov       [rsp+20],rax
M02_L03:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L02
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,9B41
       mov       rdx,7FFB16D54020
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       xor       edx,edx
       call      System.SR.GetResourceString(System.String, System.String)
       mov       dword ptr [rsi+70],0E0434352
       mov       dword ptr [rsi+74],80131500
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80131501
       mov       ecx,1A2D3
       mov       rdx,7FFB16D54020
       call      CORINFO_HELP_STRCNS
       lea       rcx,[rsi+78]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rsi+74],80070057
       mov       dword ptr [rsi+74],80131502
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 325
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rax
       call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       r8,1D2F5EF3060
       mov       r8,[r8]
       mov       rdx,1D2F5EF33F8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,7FFB171951E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1D315EFA1E0
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFE0],rax
       mov       rdx,1D305EF11B8
       mov       rdx,[rdx]
       mov       rcx,[rbp+0FFE0]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       test      ebx,ebx
       jle       short M01_L03
M01_L00:
       movsxd    rcx,edi
       lea       rcx,[rsi+rcx+10]
       mov       rax,1D2F5EF1528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1D305EF11C0
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,[rbp+0FFE0]
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       inc       edi
       cmp       ebx,edi
       jg        short M01_L00
M01_L03:
       mov       rcx,[rbp+0FFE0]
       mov       edx,27
       call      System.Text.StringBuilder.Append(Char)
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FFB17139498]
       mov       rdi,rax
       mov       rcx,1D315EFA1E0
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFE0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rdi
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rcx,7FFB171951E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1D315EFA1E0
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFE0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 350
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rax
       call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       r8,18F74E13060
       mov       r8,[r8]
       mov       rdx,18F74E133F8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,7FFB171951E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,18F54E181C8
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFE0],rax
       mov       rdx,18F64E111B8
       mov       rdx,[rdx]
       mov       rcx,[rbp+0FFE0]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       test      ebx,ebx
       jle       short M01_L03
M01_L00:
       movsxd    rcx,edi
       lea       rcx,[rsi+rcx+10]
       mov       rax,18F74E11528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,18F64E111C0
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,[rbp+0FFE0]
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       inc       edi
       cmp       ebx,edi
       jg        short M01_L00
M01_L03:
       mov       rcx,[rbp+0FFE0]
       mov       edx,27
       call      System.Text.StringBuilder.Append(Char)
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FFB17139498]
       mov       rdi,rax
       mov       rcx,18F54E181C8
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFE0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rdi
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rcx,7FFB171951E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,18F54E181C8
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFE0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 350
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rax
       call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       r8,1AD78C83060
       mov       r8,[r8]
       mov       rdx,1AD78C833F8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,7FFB171B51E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1AD98C8A1E0
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFE0],rax
       mov       rdx,1ADA8C811B8
       mov       rdx,[rdx]
       mov       rcx,[rbp+0FFE0]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       test      ebx,ebx
       jle       short M01_L03
M01_L00:
       movsxd    rcx,edi
       lea       rcx,[rsi+rcx+10]
       mov       rax,1AD78C81528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1ADA8C811C0
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,[rbp+0FFE0]
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       inc       edi
       cmp       ebx,edi
       jg        short M01_L00
M01_L03:
       mov       rcx,[rbp+0FFE0]
       mov       edx,27
       call      System.Text.StringBuilder.Append(Char)
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FFB17159498]
       mov       rdi,rax
       mov       rcx,1AD98C8A1E0
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFE0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rdi
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rcx,7FFB171B51E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1AD98C8A1E0
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFE0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 350
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rax
       call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       r8,18B8FE43060
       mov       r8,[r8]
       mov       rdx,18B8FE433F8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,7FFB171D51E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,18B9FE4A1E0
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFE0],rax
       mov       rdx,18BAFE411B8
       mov       rdx,[rdx]
       mov       rcx,[rbp+0FFE0]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       test      ebx,ebx
       jle       short M01_L03
M01_L00:
       movsxd    rcx,edi
       lea       rcx,[rsi+rcx+10]
       mov       rax,18B8FE41528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,18BAFE411C0
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,[rbp+0FFE0]
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       inc       edi
       cmp       ebx,edi
       jg        short M01_L00
M01_L03:
       mov       rcx,[rbp+0FFE0]
       mov       edx,27
       call      System.Text.StringBuilder.Append(Char)
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FFB17179498]
       mov       rdi,rax
       mov       rcx,18B9FE4A1E0
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFE0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rdi
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rcx,7FFB171D51E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,18B9FE4A1E0
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFE0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 350
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rax
       call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       r8,1F074733060
       mov       r8,[r8]
       mov       rdx,1F0747333F8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,7FFB171C51E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1F09473A1E0
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFE0],rax
       mov       rdx,1F074733E40
       mov       rdx,[rdx]
       mov       rcx,[rbp+0FFE0]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       test      ebx,ebx
       jle       short M01_L03
M01_L00:
       movsxd    rcx,edi
       lea       rcx,[rsi+rcx+10]
       mov       rax,1F074731528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1F074733E48
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,[rbp+0FFE0]
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       inc       edi
       cmp       ebx,edi
       jg        short M01_L00
M01_L03:
       mov       rcx,[rbp+0FFE0]
       mov       edx,27
       call      System.Text.StringBuilder.Append(Char)
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FFB17169498]
       mov       rdi,rax
       mov       rcx,1F09473A1E0
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFE0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rdi
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rcx,7FFB171C51E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1F09473A1E0
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFE0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 350
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rax
       call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       r8,24DB1033060
       mov       r8,[r8]
       mov       rdx,24DB10333F8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,7FFB171A51E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,24DB103C630
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFE0],rax
       mov       rdx,24DB10421F8
       mov       rdx,[rdx]
       mov       rcx,[rbp+0FFE0]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       test      ebx,ebx
       jle       short M01_L03
M01_L00:
       movsxd    rcx,edi
       lea       rcx,[rsi+rcx+10]
       mov       rax,24DB1031528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,24DB1042200
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,[rbp+0FFE0]
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       inc       edi
       cmp       ebx,edi
       jg        short M01_L00
M01_L03:
       mov       rcx,[rbp+0FFE0]
       mov       edx,27
       call      System.Text.StringBuilder.Append(Char)
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FFB17149498]
       mov       rdi,rax
       mov       rcx,24DB103C630
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFE0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rdi
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rcx,7FFB171A51E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,24DB103C630
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFE0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 350
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rax
       call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       r8,208DB693060
       mov       r8,[r8]
       mov       rdx,208DB6933F8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,7FFB171A51E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,208EB69A1E0
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFE0],rax
       mov       rdx,208FB6911B8
       mov       rdx,[rdx]
       mov       rcx,[rbp+0FFE0]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       test      ebx,ebx
       jle       short M01_L03
M01_L00:
       movsxd    rcx,edi
       lea       rcx,[rsi+rcx+10]
       mov       rax,208DB691528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,208FB6911C0
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,[rbp+0FFE0]
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       inc       edi
       cmp       ebx,edi
       jg        short M01_L00
M01_L03:
       mov       rcx,[rbp+0FFE0]
       mov       edx,27
       call      System.Text.StringBuilder.Append(Char)
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FFB17149498]
       mov       rdi,rax
       mov       rcx,208EB69A1E0
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFE0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rdi
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rcx,7FFB171A51E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,208EB69A1E0
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFE0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 350
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rax
       call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       r8,20E81041048
       mov       r8,[r8]
       mov       rdx,20E810413E0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,7FFB171C51E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,20E8104A618
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFE0],rax
       mov       rdx,20E910419F0
       mov       rdx,[rdx]
       mov       rcx,[rbp+0FFE0]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       test      ebx,ebx
       jle       short M01_L03
M01_L00:
       movsxd    rcx,edi
       lea       rcx,[rsi+rcx+10]
       mov       rax,20E71041528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,20E910419F8
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,[rbp+0FFE0]
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       inc       edi
       cmp       ebx,edi
       jg        short M01_L00
M01_L03:
       mov       rcx,[rbp+0FFE0]
       mov       edx,27
       call      System.Text.StringBuilder.Append(Char)
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FFB17169498]
       mov       rdi,rax
       mov       rcx,20E8104A618
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFE0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rdi
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rcx,7FFB171C51E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,20E8104A618
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFE0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 350
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
; 			var result = StringBuilderHelper.BytesToString(this.ByteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rcx,rax
       call      dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       r8,243E9A13060
       mov       r8,[r8]
       mov       rdx,243E9A133F8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,7FFB171C51E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,24409A1A1E0
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFE0],rax
       mov       rdx,243E9A13E40
       mov       rdx,[rdx]
       mov       rcx,[rbp+0FFE0]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       xor       edi,edi
       mov       ebx,[rsi+8]
       test      ebx,ebx
       jle       short M01_L03
M01_L00:
       movsxd    rcx,edi
       lea       rcx,[rsi+rcx+10]
       mov       rax,243E9A11528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,243E9A13E48
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,[rbp+0FFE0]
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       inc       edi
       cmp       ebx,edi
       jg        short M01_L00
M01_L03:
       mov       rcx,[rbp+0FFE0]
       mov       edx,27
       call      System.Text.StringBuilder.Append(Char)
       mov       rcx,[rbp+0FFE0]
       call      qword ptr [7FFB17169498]
       mov       rdi,rax
       mov       rcx,24409A1A1E0
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFE0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rdi
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       mov       rcx,7FFB171C51E0
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,24409A1A1E0
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFE0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 350
```

