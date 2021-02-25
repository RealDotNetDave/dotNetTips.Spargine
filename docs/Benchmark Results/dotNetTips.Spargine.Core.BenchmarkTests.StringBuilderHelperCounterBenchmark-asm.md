## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.AppendBytes03()
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
       mov       r8,18CB0F61048
       mov       r8,[r8]
       mov       rdx,18CB0F613E0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,7FFB1709E788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,18C90F65DA8
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFE0],rax
       mov       rdx,18C90F671C8
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
       mov       rax,18C90F61528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,18C90F671D0
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
       call      qword ptr [7FFB170E31E8]
       mov       rdi,rax
       mov       rcx,18C90F65DA8
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
       mov       rcx,7FFB1709E788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,18C90F65DA8
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
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.AppendBytes03()
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
       mov       r8,1ABDE763060
       mov       r8,[r8]
       mov       rdx,1ABDE7633F8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,7FFB170BE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1ABFE765DA8
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFE0],rax
       mov       rdx,1ABEE7611B8
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
       mov       rax,1ABDE761528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1ABEE7611C0
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
       call      qword ptr [7FFB171031E8]
       mov       rdi,rax
       mov       rcx,1ABFE765DA8
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
       mov       rcx,7FFB170BE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1ABFE765DA8
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
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.AppendBytes03()
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
       mov       r8,19A8C6B3060
       mov       r8,[r8]
       mov       rdx,19A8C6B33F8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,7FFB170DE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,19A8C6B61E0
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFE0],rax
       mov       rdx,19A8C6B7600
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
       mov       rax,19A8C6B1528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,19A8C6B7608
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
       call      qword ptr [7FFB171231E8]
       mov       rdi,rax
       mov       rcx,19A8C6B61E0
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
       mov       rcx,7FFB170DE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,19A8C6B61E0
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
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.AppendBytes03()
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
       mov       r8,21E26243060
       mov       r8,[r8]
       mov       rdx,21E262433F8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,7FFB170BE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,21E16243D90
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFE0],rax
       mov       rdx,21E26245E58
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
       mov       rax,21E26241528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,21E26245E60
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
       call      qword ptr [7FFB171031E8]
       mov       rdi,rax
       mov       rcx,21E16243D90
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
       mov       rcx,7FFB170BE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,21E16243D90
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
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.AppendBytes03()
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
       mov       r8,1F45D6B3060
       mov       r8,[r8]
       mov       rdx,1F45D6B33F8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,7FFB170DE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1F46D6B5DA8
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFE0],rax
       mov       rdx,1F46D6B71C8
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
       mov       rax,1F45D6B1528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1F46D6B71D0
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
       call      qword ptr [7FFB171231E8]
       mov       rdi,rax
       mov       rcx,1F46D6B5DA8
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
       mov       rcx,7FFB170DE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1F46D6B5DA8
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
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.AppendBytes03()
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
       mov       r8,15002333060
       mov       r8,[r8]
       mov       rdx,150023333F8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,7FFB170DE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,15022333D90
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFE0],rax
       mov       rdx,15002333608
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
       mov       rax,15002331528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,15002333610
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
       call      qword ptr [7FFB171231E8]
       mov       rdi,rax
       mov       rcx,15022333D90
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
       mov       rcx,7FFB170DE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,15022333D90
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
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.AppendBytes03()
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
       mov       r8,204F8D73060
       mov       r8,[r8]
       mov       rdx,204F8D733F8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,7FFB170BE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,204F8D781F8
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFE0],rax
       mov       rdx,20508D711B8
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
       mov       rax,204F8D71528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,20508D711C0
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
       call      qword ptr [7FFB171031E8]
       mov       rdi,rax
       mov       rcx,204F8D781F8
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
       mov       rcx,7FFB170BE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,204F8D781F8
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
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.AppendBytes03()
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
       mov       r8,1E243193060
       mov       r8,[r8]
       mov       rdx,1E2431933F8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,7FFB170AE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1E233193D90
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFE0],rax
       mov       rdx,1E2531D0228
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
       mov       rax,1E243191528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1E2531D0230
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
       call      qword ptr [7FFB170F31E8]
       mov       rdi,rax
       mov       rcx,1E233193D90
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
       mov       rcx,7FFB170AE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1E233193D90
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
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.AppendBytes03()
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
       mov       r8,2C5D99A3060
       mov       r8,[r8]
       mov       rdx,2C5D99A33F8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,7FFB170CE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2C5D99A81F8
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFE0],rax
       mov       rdx,2C5C9A1EA28
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
       mov       rax,2C5D99A1528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,2C5C9A1EA30
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
       call      qword ptr [7FFB171131E8]
       mov       rdi,rax
       mov       rcx,2C5D99A81F8
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
       mov       rcx,7FFB170CE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2C5D99A81F8
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
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.SplitCharSeparator01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rdi,rax
       mov       rcx,29178111180
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 99
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,29178111048
       mov       r8,[r8]
       mov       rdx,291581131D0
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,7FFB170BE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,291781161E0
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFD0],rax
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L04
       xor       r15d,r15d
       test      r14d,r14d
       jle       short M01_L04
M01_L00:
       movsxd    rcx,r15d
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       cmp       esi,0FFFFFFFE
       jne       short M01_L02
M01_L01:
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       mov       rcx,[rbp+0FFD0]
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      qword ptr [7FFB171031E8]
       mov       rsi,rax
       mov       rcx,291781161E0
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFD0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
       lea       rsp,[rbp+0FFD8]
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
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,7FFB170BE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,291781161E0
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFD0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 354
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.SplitCharSeparator01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rdi,rax
       mov       rcx,15B06A13198
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 99
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,15B06A13060
       mov       r8,[r8]
       mov       rdx,15B06A13608
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,7FFB170DE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,15B26A15DA8
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFD0],rax
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L04
       xor       r15d,r15d
       test      r14d,r14d
       jle       short M01_L04
M01_L00:
       movsxd    rcx,r15d
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       cmp       esi,0FFFFFFFE
       jne       short M01_L02
M01_L01:
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       mov       rcx,[rbp+0FFD0]
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      qword ptr [7FFB171231E8]
       mov       rsi,rax
       mov       rcx,15B26A15DA8
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFD0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
       lea       rsp,[rbp+0FFD8]
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
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,7FFB170DE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,15B26A15DA8
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFD0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 354
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.SplitCharSeparator01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rdi,rax
       mov       rcx,20196E13198
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 99
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,20196E13060
       mov       r8,[r8]
       mov       rdx,20176E151B0
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,7FFB170BE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,20176E13D90
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFD0],rax
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L04
       xor       r15d,r15d
       test      r14d,r14d
       jle       short M01_L04
M01_L00:
       movsxd    rcx,r15d
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       cmp       esi,0FFFFFFFE
       jne       short M01_L02
M01_L01:
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       mov       rcx,[rbp+0FFD0]
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      qword ptr [7FFB171031E8]
       mov       rsi,rax
       mov       rcx,20176E13D90
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFD0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
       lea       rsp,[rbp+0FFD8]
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
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,7FFB170BE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,20176E13D90
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFD0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 354
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.SplitCharSeparator01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rdi,rax
       mov       rcx,282A2D03198
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 99
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,282A2D03060
       mov       r8,[r8]
       mov       rdx,28292D011B8
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,7FFB170AE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,282A2D061E0
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFD0],rax
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L04
       xor       r15d,r15d
       test      r14d,r14d
       jle       short M01_L04
M01_L00:
       movsxd    rcx,r15d
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       cmp       esi,0FFFFFFFE
       jne       short M01_L02
M01_L01:
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       mov       rcx,[rbp+0FFD0]
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      qword ptr [7FFB170F31E8]
       mov       rsi,rax
       mov       rcx,282A2D061E0
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFD0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
       lea       rsp,[rbp+0FFD8]
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
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,7FFB170AE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,282A2D061E0
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFD0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 354
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.SplitCharSeparator01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rdi,rax
       mov       rcx,249BF833198
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 99
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,249BF833060
       mov       r8,[r8]
       mov       rdx,249EF8311B8
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,7FFB170AE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,249DF835DA8
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFD0],rax
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L04
       xor       r15d,r15d
       test      r14d,r14d
       jle       short M01_L04
M01_L00:
       movsxd    rcx,r15d
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       cmp       esi,0FFFFFFFE
       jne       short M01_L02
M01_L01:
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       mov       rcx,[rbp+0FFD0]
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      qword ptr [7FFB170F31E8]
       mov       rsi,rax
       mov       rcx,249DF835DA8
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFD0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
       lea       rsp,[rbp+0FFD8]
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
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,7FFB170AE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,249DF835DA8
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFD0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 354
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.SplitCharSeparator01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rdi,rax
       mov       rcx,1FA71193198
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 99
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,1FA71193060
       mov       r8,[r8]
       mov       rdx,1FA811971C8
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,7FFB170BE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FA81195DA8
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFD0],rax
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L04
       xor       r15d,r15d
       test      r14d,r14d
       jle       short M01_L04
M01_L00:
       movsxd    rcx,r15d
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       cmp       esi,0FFFFFFFE
       jne       short M01_L02
M01_L01:
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       mov       rcx,[rbp+0FFD0]
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      qword ptr [7FFB171031E8]
       mov       rsi,rax
       mov       rcx,1FA81195DA8
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFD0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
       lea       rsp,[rbp+0FFD8]
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
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,7FFB170BE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FA81195DA8
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFD0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 354
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.SplitCharSeparator01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rdi,rax
       mov       rcx,22D1F6E1180
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 99
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,22D1F6E1048
       mov       r8,[r8]
       mov       rdx,22CEF6E11B8
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,7FFB170DE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,22D1F6E61E0
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFD0],rax
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L04
       xor       r15d,r15d
       test      r14d,r14d
       jle       short M01_L04
M01_L00:
       movsxd    rcx,r15d
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       cmp       esi,0FFFFFFFE
       jne       short M01_L02
M01_L01:
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       mov       rcx,[rbp+0FFD0]
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      qword ptr [7FFB171231E8]
       mov       rsi,rax
       mov       rcx,22D1F6E61E0
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFD0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
       lea       rsp,[rbp+0FFD8]
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
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,7FFB170DE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,22D1F6E61E0
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFD0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 354
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.SplitCharSeparator01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rdi,rax
       mov       rcx,1CE36403198
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 99
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,1CE36403060
       mov       r8,[r8]
       mov       rdx,1CE464011B8
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,7FFB170AE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1CE26403D90
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFD0],rax
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L04
       xor       r15d,r15d
       test      r14d,r14d
       jle       short M01_L04
M01_L00:
       movsxd    rcx,r15d
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       cmp       esi,0FFFFFFFE
       jne       short M01_L02
M01_L01:
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       mov       rcx,[rbp+0FFD0]
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      qword ptr [7FFB170F31E8]
       mov       rsi,rax
       mov       rcx,1CE26403D90
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFD0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
       lea       rsp,[rbp+0FFD8]
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
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,7FFB170AE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1CE26403D90
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFD0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 354
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.SplitCharSeparator01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+10]
       mov       rdi,rax
       mov       rcx,26612393198
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
       mov       r9,rax
       mov       rdx,rbx
       mov       rcx,rdi
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 99
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.ConcatToString(System.String, System.String, dotNetTips.Spargine.Core.Tristate, System.String[])
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+0FFC0],rsp
       mov       rbx,rdx
       mov       esi,r8d
       mov       rdi,r9
       mov       r8,26612393060
       mov       r8,[r8]
       mov       rdx,265F23911B8
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,7FFB170DE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,26602393D90
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FFD0],rax
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L04
       xor       r15d,r15d
       test      r14d,r14d
       jle       short M01_L04
M01_L00:
       movsxd    rcx,r15d
       mov       rdx,[rdi+rcx*8+10]
       cmp       esi,0FFFFFFFF
       je        short M01_L01
       cmp       esi,0FFFFFFFE
       jne       short M01_L02
M01_L01:
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       mov       rcx,[rbp+0FFD0]
       call      System.Text.StringBuilder.Append(System.String)
       call      System.Environment.get_NewLine()
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       call      System.Text.StringBuilder.Append(System.String)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       call      System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
M01_L03:
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L00
M01_L04:
       mov       rcx,[rbp+0FFD0]
       cmp       [rcx],ecx
       call      qword ptr [7FFB171231E8]
       mov       rsi,rax
       mov       rcx,26602393D90
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFD0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
       lea       rsp,[rbp+0FFD8]
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
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,7FFB170DE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,26602393D90
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FFD0]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 354
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB171EE280
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M01_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L02
       mov       rax,1C179E53060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       lea       edx,[rax+rax*4]
       add       edx,edx
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB171EE868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB171EE9E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass14_0`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].<ToDelimitedString>b__0(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].ForEach(System.Action`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFB171231E8]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       dec       r8d
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
; Total bytes of code 345
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB171BE280
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M01_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L02
       mov       rax,22B8E991048
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       lea       edx,[rax+rax*4]
       add       edx,edx
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB171BE868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB171BE9E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass14_0`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].<ToDelimitedString>b__0(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].ForEach(System.Action`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFB170F31E8]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       dec       r8d
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
; Total bytes of code 345
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB171CE280
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M01_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L02
       mov       rax,1EDA9C13060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       lea       edx,[rax+rax*4]
       add       edx,edx
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB171CE868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB171CE9E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass14_0`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].<ToDelimitedString>b__0(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].ForEach(System.Action`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFB171031E8]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       dec       r8d
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
; Total bytes of code 345
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB171CE280
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M01_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L02
       mov       rax,24096823060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       lea       edx,[rax+rax*4]
       add       edx,edx
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB171CE868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB171CE9E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass14_0`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].<ToDelimitedString>b__0(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].ForEach(System.Action`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFB171031E8]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       dec       r8d
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
; Total bytes of code 345
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB171CE280
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M01_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L02
       mov       rax,15865513060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       lea       edx,[rax+rax*4]
       add       edx,edx
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB171CE868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB171CE9E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass14_0`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].<ToDelimitedString>b__0(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].ForEach(System.Action`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFB171031E8]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       dec       r8d
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
; Total bytes of code 345
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB171CE408
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M01_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L02
       mov       rax,1778C7D3060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       lea       edx,[rax+rax*4]
       add       edx,edx
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB171CE9F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB171CEB68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass14_0`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].<ToDelimitedString>b__0(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].ForEach(System.Action`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFB171031E8]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       dec       r8d
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
; Total bytes of code 345
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB171EE5C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M01_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L02
       mov       rax,15679F63060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       lea       edx,[rax+rax*4]
       add       edx,edx
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB171EEBB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB171EED28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass14_0`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].<ToDelimitedString>b__0(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].ForEach(System.Action`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFB171231E8]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       dec       r8d
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
; Total bytes of code 345
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB171DE5C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M01_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L02
       mov       rax,16C04243060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       lea       edx,[rax+rax*4]
       add       edx,edx
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB171DEBB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB171DED28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass14_0`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].<ToDelimitedString>b__0(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].ForEach(System.Action`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFB171131E8]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       dec       r8d
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
; Total bytes of code 345
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString(System.Collections.Generic.IEnumerable`1<!!0>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.ToDelimitedString[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Char)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB171BE5C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [r14+10],bx
       test      rdi,rdi
       je        short M01_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L02
       mov       rax,114F6793060
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       lea       edx,[rax+rax*4]
       add       edx,edx
       mov       rcx,rbx
       mov       r8d,7FFFFFFF
       call      System.Text.StringBuilder..ctor(Int32, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFB171BEBB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FFB171BED28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.EnumerableExtensions+<>c__DisplayClass14_0`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].<ToDelimitedString>b__0(System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].ForEach(System.Action`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rcx,[r14+8]
       mov       rsi,rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFB170F31E8]
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.StringExtensions.ToTrimmed(System.String)
       mov       r8d,[rax+8]
       dec       r8d
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Text.StringBuilder.ToString(Int32, Int32)
; Total bytes of code 345
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString02()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString(System.Collections.Generic.Dictionary`2<!!0,!!1>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       mov       [rbp+0FF80],rsp
       mov       [rbp+0FFE0],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       rsi,rdx
       mov       eax,[rsi+38]
       sub       eax,[rsi+40]
       jne       short M01_L00
       mov       rax,239C5C13060
       mov       rax,[rax]
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,7FFB1709E788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,239D5C13D90
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FF90],rax
       lea       rdx,[rbp+0FFB8]
       mov       rcx,rsi
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       short M01_L02
M01_L01:
       lea       rax,[rbp+0FFD0]
       mov       rsi,[rax]
       mov       rdi,[rax+8]
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       movzx     ebx,word ptr [rbp+20]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],bx
       mov       r8,239C5C11368
       mov       r8,[r8]
       mov       rbx,[rbp+0FF90]
       mov       rdx,239D5C151B0
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF98]
       mov       [rcx],rsi
       mov       [rcx+8],rdi
       mov       [rcx+10],rax
       mov       [rcx+18],r8
       lea       r8,[rbp+0FF98]
       xor       ecx,ecx
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
M01_L02:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       mov       rdx,[rsi+18]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB171C29A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       lea       rcx,[rbp+0FFB8]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L01
       mov       rax,[rsi+28]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB171C2A90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L06:
       lea       rcx,[rbp+0FFB8]
       call      rax
       mov       r8,[rbp+0FF90]
       mov       r8d,[r8+1C]
       mov       rcx,[rbp+0FF90]
       mov       ecx,[rcx+18]
       lea       r8d,[r8+rcx+0FFFF]
       mov       rcx,[rbp+0FF90]
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       mov       rsi,rax
       mov       rcx,239D5C13D90
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
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
       lea       rbp,[rbp+0A0]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+28],0
       je        short M01_L07
       mov       rax,[rsi+28]
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB171C2A90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L08:
       lea       rcx,[rbp+0FFB8]
       call      rax
       nop
       add       rsp,28
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
       lea       rbp,[rbp+0A0]
       mov       rcx,7FFB1709E788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,239D5C13D90
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
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
; Total bytes of code 594
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString02()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString(System.Collections.Generic.Dictionary`2<!!0,!!1>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       mov       [rbp+0FF80],rsp
       mov       [rbp+0FFE0],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       rsi,rdx
       mov       eax,[rsi+38]
       sub       eax,[rsi+40]
       jne       short M01_L00
       mov       rax,16A29373060
       mov       rax,[rax]
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,7FFB170AE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,16A293781F8
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FF90],rax
       lea       rdx,[rbp+0FFB8]
       mov       rcx,rsi
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       short M01_L02
M01_L01:
       lea       rax,[rbp+0FFD0]
       mov       rsi,[rax]
       mov       rdi,[rax+8]
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       movzx     ebx,word ptr [rbp+20]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],bx
       mov       r8,16A29371368
       mov       r8,[r8]
       mov       rbx,[rbp+0FF90]
       mov       rdx,16A393711B8
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF98]
       mov       [rcx],rsi
       mov       [rcx+8],rdi
       mov       [rcx+10],rax
       mov       [rcx+18],r8
       lea       r8,[rbp+0FF98]
       xor       ecx,ecx
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
M01_L02:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       mov       rdx,[rsi+18]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB171D29A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       lea       rcx,[rbp+0FFB8]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L01
       mov       rax,[rsi+28]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB171D2A90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L06:
       lea       rcx,[rbp+0FFB8]
       call      rax
       mov       r8,[rbp+0FF90]
       mov       r8d,[r8+1C]
       mov       rcx,[rbp+0FF90]
       mov       ecx,[rcx+18]
       lea       r8d,[r8+rcx+0FFFF]
       mov       rcx,[rbp+0FF90]
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       mov       rsi,rax
       mov       rcx,16A293781F8
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
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
       lea       rbp,[rbp+0A0]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+28],0
       je        short M01_L07
       mov       rax,[rsi+28]
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB171D2A90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L08:
       lea       rcx,[rbp+0FFB8]
       call      rax
       nop
       add       rsp,28
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
       lea       rbp,[rbp+0A0]
       mov       rcx,7FFB170AE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,16A293781F8
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
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
; Total bytes of code 594
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString02()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString(System.Collections.Generic.Dictionary`2<!!0,!!1>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       mov       [rbp+0FF80],rsp
       mov       [rbp+0FFE0],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       rsi,rdx
       mov       eax,[rsi+38]
       sub       eax,[rsi+40]
       jne       short M01_L00
       mov       rax,23982E73060
       mov       rax,[rax]
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,7FFB170AE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,239A2E75DA8
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FF90],rax
       lea       rdx,[rbp+0FFB8]
       mov       rcx,rsi
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       short M01_L02
M01_L01:
       lea       rax,[rbp+0FFD0]
       mov       rsi,[rax]
       mov       rdi,[rax+8]
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       movzx     ebx,word ptr [rbp+20]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],bx
       mov       r8,23982E71368
       mov       r8,[r8]
       mov       rbx,[rbp+0FF90]
       mov       rdx,23992E711B8
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF98]
       mov       [rcx],rsi
       mov       [rcx+8],rdi
       mov       [rcx+10],rax
       mov       [rcx+18],r8
       lea       r8,[rbp+0FF98]
       xor       ecx,ecx
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
M01_L02:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       mov       rdx,[rsi+18]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB171D29A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       lea       rcx,[rbp+0FFB8]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L01
       mov       rax,[rsi+28]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB171D2A90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L06:
       lea       rcx,[rbp+0FFB8]
       call      rax
       mov       r8,[rbp+0FF90]
       mov       r8d,[r8+1C]
       mov       rcx,[rbp+0FF90]
       mov       ecx,[rcx+18]
       lea       r8d,[r8+rcx+0FFFF]
       mov       rcx,[rbp+0FF90]
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       mov       rsi,rax
       mov       rcx,239A2E75DA8
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
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
       lea       rbp,[rbp+0A0]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+28],0
       je        short M01_L07
       mov       rax,[rsi+28]
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB171D2A90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L08:
       lea       rcx,[rbp+0FFB8]
       call      rax
       nop
       add       rsp,28
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
       lea       rbp,[rbp+0A0]
       mov       rcx,7FFB170AE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,239A2E75DA8
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
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
; Total bytes of code 594
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString02()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString(System.Collections.Generic.Dictionary`2<!!0,!!1>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       mov       [rbp+0FF80],rsp
       mov       [rbp+0FFE0],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       rsi,rdx
       mov       eax,[rsi+38]
       sub       eax,[rsi+40]
       jne       short M01_L00
       mov       rax,21F9BBA3060
       mov       rax,[rax]
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,7FFB170AE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,21F8BBA3D90
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FF90],rax
       lea       rdx,[rbp+0FFB8]
       mov       rcx,rsi
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       short M01_L02
M01_L01:
       lea       rax,[rbp+0FFD0]
       mov       rsi,[rax]
       mov       rdi,[rax+8]
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       movzx     ebx,word ptr [rbp+20]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],bx
       mov       r8,21F9BBA1368
       mov       r8,[r8]
       mov       rbx,[rbp+0FF90]
       mov       rdx,21FABBA11B8
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF98]
       mov       [rcx],rsi
       mov       [rcx+8],rdi
       mov       [rcx+10],rax
       mov       [rcx+18],r8
       lea       r8,[rbp+0FF98]
       xor       ecx,ecx
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
M01_L02:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       mov       rdx,[rsi+18]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB171D29A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       lea       rcx,[rbp+0FFB8]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L01
       mov       rax,[rsi+28]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB171D2A90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L06:
       lea       rcx,[rbp+0FFB8]
       call      rax
       mov       r8,[rbp+0FF90]
       mov       r8d,[r8+1C]
       mov       rcx,[rbp+0FF90]
       mov       ecx,[rcx+18]
       lea       r8d,[r8+rcx+0FFFF]
       mov       rcx,[rbp+0FF90]
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       mov       rsi,rax
       mov       rcx,21F8BBA3D90
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
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
       lea       rbp,[rbp+0A0]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+28],0
       je        short M01_L07
       mov       rax,[rsi+28]
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB171D2A90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L08:
       lea       rcx,[rbp+0FFB8]
       call      rax
       nop
       add       rsp,28
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
       lea       rbp,[rbp+0A0]
       mov       rcx,7FFB170AE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,21F8BBA3D90
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
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
; Total bytes of code 594
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString02()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString(System.Collections.Generic.Dictionary`2<!!0,!!1>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       mov       [rbp+0FF80],rsp
       mov       [rbp+0FFE0],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       rsi,rdx
       mov       eax,[rsi+38]
       sub       eax,[rsi+40]
       jne       short M01_L00
       mov       rax,22521F81048
       mov       rax,[rax]
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,7FFB170AE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,22521F861E0
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FF90],rax
       lea       rdx,[rbp+0FFB8]
       mov       rcx,rsi
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       short M01_L02
M01_L01:
       lea       rax,[rbp+0FFD0]
       mov       rsi,[rax]
       mov       rdi,[rax+8]
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       movzx     ebx,word ptr [rbp+20]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],bx
       mov       r8,22501F81368
       mov       r8,[r8]
       mov       rbx,[rbp+0FF90]
       mov       rdx,22521F87600
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF98]
       mov       [rcx],rsi
       mov       [rcx+8],rdi
       mov       [rcx+10],rax
       mov       [rcx+18],r8
       lea       r8,[rbp+0FF98]
       xor       ecx,ecx
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
M01_L02:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       mov       rdx,[rsi+18]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB171D29A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       lea       rcx,[rbp+0FFB8]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L01
       mov       rax,[rsi+28]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB171D2A90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L06:
       lea       rcx,[rbp+0FFB8]
       call      rax
       mov       r8,[rbp+0FF90]
       mov       r8d,[r8+1C]
       mov       rcx,[rbp+0FF90]
       mov       ecx,[rcx+18]
       lea       r8d,[r8+rcx+0FFFF]
       mov       rcx,[rbp+0FF90]
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       mov       rsi,rax
       mov       rcx,22521F861E0
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
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
       lea       rbp,[rbp+0A0]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+28],0
       je        short M01_L07
       mov       rax,[rsi+28]
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB171D2A90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L08:
       lea       rcx,[rbp+0FFB8]
       call      rax
       nop
       add       rsp,28
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
       lea       rbp,[rbp+0A0]
       mov       rcx,7FFB170AE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,22521F861E0
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
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
; Total bytes of code 594
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString02()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString(System.Collections.Generic.Dictionary`2<!!0,!!1>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       mov       [rbp+0FF80],rsp
       mov       [rbp+0FFE0],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       rsi,rdx
       mov       eax,[rsi+38]
       sub       eax,[rsi+40]
       jne       short M01_L00
       mov       rax,21689083060
       mov       rax,[rax]
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,7FFB170CE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,216A9085DA8
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FF90],rax
       lea       rdx,[rbp+0FFB8]
       mov       rcx,rsi
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       short M01_L02
M01_L01:
       lea       rax,[rbp+0FFD0]
       mov       rsi,[rax]
       mov       rdi,[rax+8]
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       movzx     ebx,word ptr [rbp+20]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],bx
       mov       r8,21689081368
       mov       r8,[r8]
       mov       rbx,[rbp+0FF90]
       mov       rdx,216B90811B8
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF98]
       mov       [rcx],rsi
       mov       [rcx+8],rdi
       mov       [rcx+10],rax
       mov       [rcx+18],r8
       lea       r8,[rbp+0FF98]
       xor       ecx,ecx
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
M01_L02:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       mov       rdx,[rsi+18]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB171F29A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       lea       rcx,[rbp+0FFB8]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L01
       mov       rax,[rsi+28]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB171F2A90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L06:
       lea       rcx,[rbp+0FFB8]
       call      rax
       mov       r8,[rbp+0FF90]
       mov       r8d,[r8+1C]
       mov       rcx,[rbp+0FF90]
       mov       ecx,[rcx+18]
       lea       r8d,[r8+rcx+0FFFF]
       mov       rcx,[rbp+0FF90]
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       mov       rsi,rax
       mov       rcx,216A9085DA8
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
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
       lea       rbp,[rbp+0A0]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+28],0
       je        short M01_L07
       mov       rax,[rsi+28]
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB171F2A90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L08:
       lea       rcx,[rbp+0FFB8]
       call      rax
       nop
       add       rsp,28
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
       lea       rbp,[rbp+0A0]
       mov       rcx,7FFB170CE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,216A9085DA8
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
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
; Total bytes of code 594
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString02()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString(System.Collections.Generic.Dictionary`2<!!0,!!1>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       mov       [rbp+0FF80],rsp
       mov       [rbp+0FFE0],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       rsi,rdx
       mov       eax,[rsi+38]
       sub       eax,[rsi+40]
       jne       short M01_L00
       mov       rax,267EE823060
       mov       rax,[rax]
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,7FFB170DE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,267FE825DA8
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FF90],rax
       lea       rdx,[rbp+0FFB8]
       mov       rcx,rsi
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       short M01_L02
M01_L01:
       lea       rax,[rbp+0FFD0]
       mov       rsi,[rax]
       mov       rdi,[rax+8]
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       movzx     ebx,word ptr [rbp+20]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],bx
       mov       r8,267EE821368
       mov       r8,[r8]
       mov       rbx,[rbp+0FF90]
       mov       rdx,2680E8219F0
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF98]
       mov       [rcx],rsi
       mov       [rcx+8],rdi
       mov       [rcx+10],rax
       mov       [rcx+18],r8
       lea       r8,[rbp+0FF98]
       xor       ecx,ecx
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
M01_L02:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       mov       rdx,[rsi+18]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB172029A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       lea       rcx,[rbp+0FFB8]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L01
       mov       rax,[rsi+28]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB17202A90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L06:
       lea       rcx,[rbp+0FFB8]
       call      rax
       mov       r8,[rbp+0FF90]
       mov       r8d,[r8+1C]
       mov       rcx,[rbp+0FF90]
       mov       ecx,[rcx+18]
       lea       r8d,[r8+rcx+0FFFF]
       mov       rcx,[rbp+0FF90]
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       mov       rsi,rax
       mov       rcx,267FE825DA8
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
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
       lea       rbp,[rbp+0A0]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+28],0
       je        short M01_L07
       mov       rax,[rsi+28]
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB17202A90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L08:
       lea       rcx,[rbp+0FFB8]
       call      rax
       nop
       add       rsp,28
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
       lea       rbp,[rbp+0A0]
       mov       rcx,7FFB170DE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,267FE825DA8
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
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
; Total bytes of code 594
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString02()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString(System.Collections.Generic.Dictionary`2<!!0,!!1>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       mov       [rbp+0FF80],rsp
       mov       [rbp+0FFE0],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       rsi,rdx
       mov       eax,[rsi+38]
       sub       eax,[rsi+40]
       jne       short M01_L00
       mov       rax,15A5CDD3060
       mov       rax,[rax]
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,7FFB170CE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,15A6CDD3D90
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FF90],rax
       lea       rdx,[rbp+0FFB8]
       mov       rcx,rsi
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       short M01_L02
M01_L01:
       lea       rax,[rbp+0FFD0]
       mov       rsi,[rax]
       mov       rdi,[rax+8]
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       movzx     ebx,word ptr [rbp+20]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],bx
       mov       r8,15A5CDD1368
       mov       r8,[r8]
       mov       rbx,[rbp+0FF90]
       mov       rdx,15A7CDD31D0
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF98]
       mov       [rcx],rsi
       mov       [rcx+8],rdi
       mov       [rcx+10],rax
       mov       [rcx+18],r8
       lea       r8,[rbp+0FF98]
       xor       ecx,ecx
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
M01_L02:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       mov       rdx,[rsi+18]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB171F29A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       lea       rcx,[rbp+0FFB8]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L01
       mov       rax,[rsi+28]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB171F2A90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L06:
       lea       rcx,[rbp+0FFB8]
       call      rax
       mov       r8,[rbp+0FF90]
       mov       r8d,[r8+1C]
       mov       rcx,[rbp+0FF90]
       mov       ecx,[rcx+18]
       lea       r8d,[r8+rcx+0FFFF]
       mov       rcx,[rbp+0FF90]
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       mov       rsi,rax
       mov       rcx,15A6CDD3D90
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
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
       lea       rbp,[rbp+0A0]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+28],0
       je        short M01_L07
       mov       rax,[rsi+28]
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB171F2A90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L08:
       lea       rcx,[rbp+0FFB8]
       call      rax
       nop
       add       rsp,28
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
       lea       rbp,[rbp+0A0]
       mov       rcx,7FFB170CE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,15A6CDD3D90
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
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
; Total bytes of code 594
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.ToDelimitedString02()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString(System.Collections.Generic.Dictionary`2<!!0,!!1>, Char)
       mov       r8d,2C
       call      dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Core.StringBuilderHelper.ToDelimitedString[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>, Char)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       mov       [rbp+0FF80],rsp
       mov       [rbp+0FFE0],rcx
       mov       [rbp+10],rcx
       mov       [rbp+20],r8d
       mov       rsi,rdx
       mov       eax,[rsi+38]
       sub       eax,[rsi+40]
       jne       short M01_L00
       mov       rax,1E9260F3060
       mov       rax,[rax]
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L00:
       mov       rcx,7FFB170AE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1E9460F5DA8
       mov       rcx,[rcx]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp+0FF90],rax
       lea       rdx,[rbp+0FFB8]
       mov       rcx,rsi
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetEnumerator()
       nop
       jmp       short M01_L02
M01_L01:
       lea       rax,[rbp+0FFD0]
       mov       rsi,[rax]
       mov       rdi,[rax+8]
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       movzx     ebx,word ptr [rbp+20]
       mov       ecx,1
       call      System.String.FastAllocateString(Int32)
       mov       [rax+0C],bx
       mov       r8,1E9260F1368
       mov       r8,[r8]
       mov       rbx,[rbp+0FF90]
       mov       rdx,1E9460F71C8
       mov       rdx,[rdx]
       lea       rcx,[rbp+0FF98]
       mov       [rcx],rsi
       mov       [rcx+8],rdi
       mov       [rcx+10],rax
       mov       [rcx+18],r8
       lea       r8,[rbp+0FF98]
       xor       ecx,ecx
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
M01_L02:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       mov       rdx,[rsi+18]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB171D29A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       lea       rcx,[rbp+0FFB8]
       call      System.Collections.Generic.Dictionary`2+Enumerator[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       jne       near ptr M01_L01
       mov       rax,[rsi+28]
       test      rax,rax
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB171D2A90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L06:
       lea       rcx,[rbp+0FFB8]
       call      rax
       mov       r8,[rbp+0FF90]
       mov       r8d,[r8+1C]
       mov       rcx,[rbp+0FF90]
       mov       ecx,[rcx+18]
       lea       r8d,[r8+rcx+0FFFF]
       mov       rcx,[rbp+0FF90]
       xor       edx,edx
       call      System.Text.StringBuilder.ToString(Int32, Int32)
       mov       rsi,rax
       mov       rcx,1E9460F5DA8
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rax,rsi
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
       lea       rbp,[rbp+0A0]
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+10]
       cmp       qword ptr [rsi+28],0
       je        short M01_L07
       mov       rax,[rsi+28]
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FFB171D2A90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
M01_L08:
       lea       rcx,[rbp+0FFB8]
       call      rax
       nop
       add       rsp,28
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
       lea       rbp,[rbp+0A0]
       mov       rcx,7FFB170AE788
       mov       edx,23
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1E9460F5DA8
       mov       rcx,[rcx]
       mov       rdx,[rbp+0FF90]
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
; Total bytes of code 594
```

