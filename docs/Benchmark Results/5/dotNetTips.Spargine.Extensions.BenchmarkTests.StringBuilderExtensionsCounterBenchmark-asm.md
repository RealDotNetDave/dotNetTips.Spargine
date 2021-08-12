## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9EA0E7D20]
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
       mov       r8,1E6940B3020
       mov       r8,[r8]
       mov       rdx,1E6840B1240
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1E6940B3020
       mov       r8,[r8]
       mov       rdx,1E6940B33B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rdx,1E6840B1248
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
       mov       rax,1E6940B1508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1E6840B1250
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
       add       ebx,1
       jo        short M01_L04
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
M01_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 217
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
       mov       rax,1E6940B3020
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
       mov       rdx,7FF9E9CD4020
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
       mov       rdx,7FF9E9CD4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9EA117D20]
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
       mov       r8,1CEAE023020
       mov       r8,[r8]
       mov       rdx,1CEAE031DD0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1CEAE023020
       mov       r8,[r8]
       mov       rdx,1CEAE0233B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rdx,1CEAE031DD8
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
       mov       rax,1CEAE021508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1CEAE031DE0
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
       add       ebx,1
       jo        short M01_L04
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
M01_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 217
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
       mov       rax,1CEAE023020
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
       mov       rdx,7FF9E9D04020
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
       mov       rdx,7FF9E9D04020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9EA0F7D20]
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
       mov       r8,1C10C821028
       mov       r8,[r8]
       mov       rdx,1C0FC821240
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1C10C821028
       mov       r8,[r8]
       mov       rdx,1C10C8213C0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rdx,1C0FC821248
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
       mov       rax,1C0EC821508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1C0FC821250
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
       add       ebx,1
       jo        short M01_L04
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
M01_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 217
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
       mov       rax,1C10C821028
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
       mov       rdx,7FF9E9CE4020
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
       mov       rdx,7FF9E9CE4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9EA0F7D20]
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
       mov       r8,24F73953020
       mov       r8,[r8]
       mov       rdx,24F73953650
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,24F73953020
       mov       r8,[r8]
       mov       rdx,24F739533B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rdx,24F73953658
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
       mov       rax,24F73951508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,24F73953660
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
       add       ebx,1
       jo        short M01_L04
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
M01_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 217
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
       mov       rax,24F73953020
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
       mov       rdx,7FF9E9CE4020
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
       mov       rdx,7FF9E9CE4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9EA117D20]
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
       mov       r8,23B30733020
       mov       r8,[r8]
       mov       rdx,23B30733650
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,23B30733020
       mov       r8,[r8]
       mov       rdx,23B307333B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rdx,23B30733658
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
       mov       rax,23B30731508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,23B30733660
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
       add       ebx,1
       jo        short M01_L04
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
M01_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 217
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
       mov       rax,23B30733020
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
       mov       rdx,7FF9E9D04020
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
       mov       rdx,7FF9E9D04020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9EA117D20]
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
       mov       r8,22A255C3020
       mov       r8,[r8]
       mov       rdx,22A255D1DD0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,22A255C3020
       mov       r8,[r8]
       mov       rdx,22A255C33B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rdx,22A255D1DD8
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
       mov       rax,22A255C1508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,22A255D1DE0
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
       add       ebx,1
       jo        short M01_L04
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
M01_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 217
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
       mov       rax,22A255C3020
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
       mov       rdx,7FF9E9D04020
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
       mov       rdx,7FF9E9D04020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9EA117D20]
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
       mov       r8,2130D173020
       mov       r8,[r8]
       mov       rdx,2130D181DD0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,2130D173020
       mov       r8,[r8]
       mov       rdx,2130D1733B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rdx,2130D181DD8
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
       mov       rax,2130D171508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,2130D181DE0
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
       add       ebx,1
       jo        short M01_L04
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
M01_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 217
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
       mov       rax,2130D173020
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
       mov       rdx,7FF9E9D04020
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
       mov       rdx,7FF9E9D04020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+18]
       cmp       dword ptr [rax+8],0
       jle       short M00_L01
; 				var testString = this.StringArray[i];
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
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
       call      qword ptr [rax+18]
       cmp       [rax+8],ebx
       jg        short M00_L00
M00_L01:
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9EA127D20]
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
       mov       r8,2853E243020
       mov       r8,[r8]
       mov       rdx,2853E251DD0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,2853E243020
       mov       r8,[r8]
       mov       rdx,2853E251740
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       r8,2853E243020
       mov       r8,[r8]
       mov       rdx,2853E251C70
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
       mov       rcx,7FF9EA175B68
       mov       edx,29
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       ebp,[rdi+8]
M01_L01:
       mov       r9,2853E24BBE0
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
       jo        near ptr M01_L07
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      System.Text.StringBuilder.Append(Char)
       cmp       r15d,ebp
       jae       near ptr M01_L08
       movsxd    rdx,r15d
       movzx     edx,word ptr [rdi+rdx*2+0C]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(Char)
       mov       ebx,r15d
       add       ebx,1
       jo        short M01_L07
       jmp       short M01_L01
M01_L02:
       mov       r9d,ebp
       sub       r9d,ebx
       jo        short M01_L07
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
       mov       rdx,2853E251650
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
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 431
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
       mov       rax,2853E243020
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
       mov       rdx,7FF9E9D14020
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
       mov       rdx,7FF9E9D14020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+18]
       cmp       dword ptr [rax+8],0
       jle       short M00_L01
; 				var testString = this.StringArray[i];
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
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
       call      qword ptr [rax+18]
       cmp       [rax+8],ebx
       jg        short M00_L00
M00_L01:
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9EA117D20]
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
       mov       r8,193476B1028
       mov       r8,[r8]
       mov       rdx,193276B3238
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,193476B1028
       mov       r8,[r8]
       mov       rdx,193476BF748
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       r8,193476B1028
       mov       r8,[r8]
       mov       rdx,193276B30D8
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
       mov       rcx,7FF9EA165B68
       mov       edx,29
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       ebp,[rdi+8]
M01_L01:
       mov       r9,193476B9BE8
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
       jo        near ptr M01_L07
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      System.Text.StringBuilder.Append(Char)
       cmp       r15d,ebp
       jae       near ptr M01_L08
       movsxd    rdx,r15d
       movzx     edx,word ptr [rdi+rdx*2+0C]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(Char)
       mov       ebx,r15d
       add       ebx,1
       jo        short M01_L07
       jmp       short M01_L01
M01_L02:
       mov       r9d,ebp
       sub       r9d,ebx
       jo        short M01_L07
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
       mov       rdx,193476BF658
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
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 431
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
       mov       rax,193476B1028
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
       mov       rdx,7FF9E9D04020
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
       mov       rdx,7FF9E9D04020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+18]
       cmp       dword ptr [rax+8],0
       jle       short M00_L01
; 				var testString = this.StringArray[i];
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
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
       call      qword ptr [rax+18]
       cmp       [rax+8],ebx
       jg        short M00_L00
M00_L01:
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9EA117D20]
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
       mov       r8,2DA5FFE3020
       mov       r8,[r8]
       mov       rdx,2DA4FFED1B0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,2DA5FFE3020
       mov       r8,[r8]
       mov       rdx,2DA3FFE13C8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       r8,2DA5FFE3020
       mov       r8,[r8]
       mov       rdx,2DA4FFED050
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
       mov       rcx,7FF9EA165B68
       mov       edx,29
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       ebp,[rdi+8]
M01_L01:
       mov       r9,2DA4FFE77D8
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
       jo        near ptr M01_L07
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      System.Text.StringBuilder.Append(Char)
       cmp       r15d,ebp
       jae       near ptr M01_L08
       movsxd    rdx,r15d
       movzx     edx,word ptr [rdi+rdx*2+0C]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(Char)
       mov       ebx,r15d
       add       ebx,1
       jo        short M01_L07
       jmp       short M01_L01
M01_L02:
       mov       r9d,ebp
       sub       r9d,ebx
       jo        short M01_L07
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
       mov       rdx,2DA3FFE12D8
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
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 431
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
       mov       rax,2DA5FFE3020
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
       mov       rdx,7FF9E9D04020
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
       mov       rdx,7FF9E9D04020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+18]
       cmp       dword ptr [rax+8],0
       jle       short M00_L01
; 				var testString = this.StringArray[i];
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
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
       call      qword ptr [rax+18]
       cmp       [rax+8],ebx
       jg        short M00_L00
M00_L01:
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9EA127D20]
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
       mov       r8,1C169AF1028
       mov       r8,[r8]
       mov       rdx,1C169AFFDD8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1C169AF1028
       mov       r8,[r8]
       mov       rdx,1C169AFF748
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       r8,1C169AF1028
       mov       r8,[r8]
       mov       rdx,1C169AFFC78
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
       mov       rcx,7FF9EA175B68
       mov       edx,29
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       ebp,[rdi+8]
M01_L01:
       mov       r9,1C169AF9BE8
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
       jo        near ptr M01_L07
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      System.Text.StringBuilder.Append(Char)
       cmp       r15d,ebp
       jae       near ptr M01_L08
       movsxd    rdx,r15d
       movzx     edx,word ptr [rdi+rdx*2+0C]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(Char)
       mov       ebx,r15d
       add       ebx,1
       jo        short M01_L07
       jmp       short M01_L01
M01_L02:
       mov       r9d,ebp
       sub       r9d,ebx
       jo        short M01_L07
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
       mov       rdx,1C169AFF658
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
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 431
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
       mov       rax,1C169AF1028
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
       mov       rdx,7FF9E9D14020
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
       mov       rdx,7FF9E9D14020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+18]
       cmp       dword ptr [rax+8],0
       jle       short M00_L01
; 				var testString = this.StringArray[i];
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
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
       call      qword ptr [rax+18]
       cmp       [rax+8],ebx
       jg        short M00_L00
M00_L01:
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9EA0E7D20]
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
       mov       r8,23C22F63020
       mov       r8,[r8]
       mov       rdx,23C02F61240
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,23C22F63020
       mov       r8,[r8]
       mov       rdx,23C22F71740
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       r8,23C22F63020
       mov       r8,[r8]
       mov       rdx,23C02F610E0
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
       mov       rcx,7FF9EA135B68
       mov       edx,29
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       ebp,[rdi+8]
M01_L01:
       mov       r9,23C22F6BBE0
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
       jo        near ptr M01_L07
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      System.Text.StringBuilder.Append(Char)
       cmp       r15d,ebp
       jae       near ptr M01_L08
       movsxd    rdx,r15d
       movzx     edx,word ptr [rdi+rdx*2+0C]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(Char)
       mov       ebx,r15d
       add       ebx,1
       jo        short M01_L07
       jmp       short M01_L01
M01_L02:
       mov       r9d,ebp
       sub       r9d,ebx
       jo        short M01_L07
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
       mov       rdx,23C22F71650
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
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 431
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
       mov       rax,23C22F63020
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
       mov       rdx,7FF9E9CD4020
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
       mov       rdx,7FF9E9CD4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+18]
       cmp       dword ptr [rax+8],0
       jle       short M00_L01
; 				var testString = this.StringArray[i];
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
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
       call      qword ptr [rax+18]
       cmp       [rax+8],ebx
       jg        short M00_L00
M00_L01:
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9EA0F7D20]
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
       mov       r8,266CC173020
       mov       r8,[r8]
       mov       rdx,266BC17D1B0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,266CC173020
       mov       r8,[r8]
       mov       rdx,266AC1713C8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       r8,266CC173020
       mov       r8,[r8]
       mov       rdx,266BC17D050
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
       mov       rcx,7FF9EA145B68
       mov       edx,29
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       ebp,[rdi+8]
M01_L01:
       mov       r9,266BC1777D8
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
       jo        near ptr M01_L07
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      System.Text.StringBuilder.Append(Char)
       cmp       r15d,ebp
       jae       near ptr M01_L08
       movsxd    rdx,r15d
       movzx     edx,word ptr [rdi+rdx*2+0C]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(Char)
       mov       ebx,r15d
       add       ebx,1
       jo        short M01_L07
       jmp       short M01_L01
M01_L02:
       mov       r9d,ebp
       sub       r9d,ebx
       jo        short M01_L07
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
       mov       rdx,266AC1712D8
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
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 431
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
       mov       rax,266CC173020
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
       mov       rdx,7FF9E9CE4020
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
       mov       rdx,7FF9E9CE4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       call      qword ptr [rax+18]
       cmp       dword ptr [rax+8],0
       jle       short M00_L01
; 				var testString = this.StringArray[i];
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M00_L00:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
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
       call      qword ptr [rax+18]
       cmp       [rax+8],ebx
       jg        short M00_L00
M00_L01:
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9EA0F7D20]
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
       mov       r8,1F57BD83020
       mov       r8,[r8]
       mov       rdx,1F55BD81240
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1F57BD83020
       mov       r8,[r8]
       mov       rdx,1F57BD91740
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       r8,1F57BD83020
       mov       r8,[r8]
       mov       rdx,1F55BD810E0
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
       mov       rcx,7FF9EA145B68
       mov       edx,29
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       ebp,[rdi+8]
M01_L01:
       mov       r9,1F57BD8BBE0
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
       jo        near ptr M01_L07
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,ebx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       rcx,rsi
       mov       edx,5C
       call      System.Text.StringBuilder.Append(Char)
       cmp       r15d,ebp
       jae       near ptr M01_L08
       movsxd    rdx,r15d
       movzx     edx,word ptr [rdi+rdx*2+0C]
       mov       rcx,rsi
       call      System.Text.StringBuilder.Append(Char)
       mov       ebx,r15d
       add       ebx,1
       jo        short M01_L07
       jmp       short M01_L01
M01_L02:
       mov       r9d,ebp
       sub       r9d,ebx
       jo        short M01_L07
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
       mov       rdx,1F57BD91650
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
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 431
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
       mov       rax,1F57BD83020
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
       mov       rdx,7FF9E9CE4020
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
       mov       rdx,7FF9E9CE4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rcx,1EDE83512D8
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9EA0E7D20]
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
       mov       rdx,1EE083615B8
       mov       rdx,[rdx]
       mov       r8,1EE08353020
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1EE08353020
       mov       r8,[r8]
       mov       rdx,1EE083615C0
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
       mov       rax,1EE08353020
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
       mov       rdx,7FF9E9CD4020
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
       mov       rdx,7FF9E9CD4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rcx,11CD0371650
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9EA0F7D20]
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
       mov       rdx,11CE0361240
       mov       rdx,[rdx]
       mov       r8,11CD0363020
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,11CD0363020
       mov       r8,[r8]
       mov       rdx,11CE0361248
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
       mov       rax,11CD0363020
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
       mov       rdx,7FF9E9CE4020
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
       mov       rdx,7FF9E9CE4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rcx,22746FF12D8
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9EA107D20]
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
       mov       rdx,227670015B8
       mov       rdx,[rdx]
       mov       r8,22766FF3020
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,22766FF3020
       mov       r8,[r8]
       mov       rdx,227670015C0
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
       mov       rax,22766FF3020
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
       mov       rdx,7FF9E9CF4020
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
       mov       rdx,7FF9E9CF4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rcx,1CDDF7836E8
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9EA127D20]
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
       mov       rdx,1CDBF783238
       mov       rdx,[rdx]
       mov       r8,1CDDF781028
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1CDDF781028
       mov       r8,[r8]
       mov       rdx,1CDBF783240
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
       mov       rax,1CDDF781028
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
       mov       rdx,7FF9E9D14020
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
       mov       rdx,7FF9E9D14020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rcx,207C733F658
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9EA0E7D20]
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
       mov       rdx,207C733FDD8
       mov       rdx,[rdx]
       mov       r8,207C7331028
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,207C7331028
       mov       r8,[r8]
       mov       rdx,207C733FDE0
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
       mov       rax,207C7331028
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
       mov       rdx,7FF9E9CD4020
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
       mov       rdx,7FF9E9CD4020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rcx,18247A21650
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9EA117D20]
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
       mov       rdx,18247A21DD0
       mov       rdx,[rdx]
       mov       r8,18247A13020
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,18247A13020
       mov       r8,[r8]
       mov       rdx,18247A21DD8
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
       mov       rax,18247A13020
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
       mov       rdx,7FF9E9D04020
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
       mov       rdx,7FF9E9D04020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rcx,1F52E10F240
       mov       rbx,[rcx]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rsi,[rsi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9EA117D20]
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
       mov       rdx,1F53E101240
       mov       rdx,[rdx]
       mov       r8,1F51E103020
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1F51E103020
       mov       r8,[r8]
       mov       rdx,1F53E101248
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
       mov       rax,1F51E103020
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
       mov       rdx,7FF9E9D04020
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
       mov       rdx,7FF9E9D04020
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

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,17C45AC3020
       mov       r8,[r8]
       mov       rdx,17C45AC33B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
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
       mov       rdx,17C45AC3650
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,17C45AC1508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,17C45AC3658
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rdi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L04
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       mov       edx,27
       call      System.Text.StringBuilder.Append(Char)
       mov       rcx,rdi
       mov       rax,[7FF9EA107D20]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M01_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 246
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,18843783020
       mov       r8,[r8]
       mov       rdx,188437833B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
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
       mov       rdx,18843783E68
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,18843781508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,18843783E70
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rdi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L04
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       mov       edx,27
       call      System.Text.StringBuilder.Append(Char)
       mov       rcx,rdi
       mov       rax,[7FF9EA107D20]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M01_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 246
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,211E5D83020
       mov       r8,[r8]
       mov       rdx,211E5D833B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
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
       mov       rdx,211D5D81240
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,211E5D81508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,211D5D81248
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rdi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L04
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       mov       edx,27
       call      System.Text.StringBuilder.Append(Char)
       mov       rcx,rdi
       mov       rax,[7FF9EA0F7D20]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M01_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 246
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,23033121028
       mov       r8,[r8]
       mov       rdx,230331213C0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
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
       mov       rdx,23013123238
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,23013121508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,23013123240
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rdi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L04
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       mov       edx,27
       call      System.Text.StringBuilder.Append(Char)
       mov       rcx,rdi
       mov       rax,[7FF9EA117D20]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M01_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 246
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,27B910B3020
       mov       r8,[r8]
       mov       rdx,27B910B33B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
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
       mov       rdx,27BB10B1240
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,27B910B1508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,27BB10B1248
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rdi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L04
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       mov       edx,27
       call      System.Text.StringBuilder.Append(Char)
       mov       rcx,rdi
       mov       rax,[7FF9EA107D20]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M01_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 246
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,27B62073020
       mov       r8,[r8]
       mov       rdx,27B620733B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
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
       mov       rdx,27B42071240
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,27B62071508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,27B42071248
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rdi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L04
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       mov       edx,27
       call      System.Text.StringBuilder.Append(Char)
       mov       rcx,rdi
       mov       rax,[7FF9EA117D20]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M01_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 246
```

## .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
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
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
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
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,1E87E473020
       mov       r8,[r8]
       mov       rdx,1E87E4733B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
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
       mov       rdx,1E88E47F1A8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,1E87E471508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1E88E47F1B0
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rdi
       mov       rdx,rax
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L04
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       mov       edx,27
       call      System.Text.StringBuilder.Append(Char)
       mov       rcx,rdi
       mov       rax,[7FF9EA117D20]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
M01_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 246
```

