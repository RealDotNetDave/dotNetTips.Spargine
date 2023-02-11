## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2B0]
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 45
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L05
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
       mov       rdx,10E8ACFB798
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,10E8ACF1568
       mov       r14,[rdx]
       mov       rdx,10E8ACFB7A0
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L04
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M01_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L03:
       mov       rcx,rdi
       mov       rax,[7FFB52E22180]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rsi,rax
       mov       rcx,10E8ACF31D8
       mov       rcx,[rcx]
       mov       rdx,10E8ACF3090
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rsi
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L06
       cmp       dword ptr [rcx+8],0
       je        short M01_L06
       xor       eax,eax
       jmp       short M01_L07
M01_L06:
       mov       eax,1
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 570
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2B0]
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 45
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L05
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
       mov       rdx,20072233B80
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,20072231568
       mov       r14,[rdx]
       mov       rdx,20072233B88
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L04
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M01_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L03:
       mov       rcx,rdi
       mov       rax,[7FFB52E32180]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rsi,rax
       mov       rcx,200922311E0
       mov       rcx,[rcx]
       mov       rdx,20092231098
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rsi
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L06
       cmp       dword ptr [rcx+8],0
       je        short M01_L06
       xor       eax,eax
       jmp       short M01_L07
M01_L06:
       mov       eax,1
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B378E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B378E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B378E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 570
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2B0]
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 45
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L05
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
       mov       rdx,1A30565AF80
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,1A305651568
       mov       r14,[rdx]
       mov       rdx,1A30565AF88
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L04
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M01_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L03:
       mov       rcx,rdi
       mov       rax,[7FFB52E02180]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rsi,rax
       mov       rcx,1A3056531D8
       mov       rcx,[rcx]
       mov       rdx,1A305653090
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rsi
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L06
       cmp       dword ptr [rcx+8],0
       je        short M01_L06
       xor       eax,eax
       jmp       short M01_L07
M01_L06:
       mov       eax,1
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B078E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B078E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B078E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 570
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2B0]
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 45
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L05
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
       mov       rdx,2648E121B88
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,2646E121568
       mov       r14,[rdx]
       mov       rdx,2648E121B90
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L04
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M01_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L03:
       mov       rcx,rdi
       mov       rax,[7FFB52E42180]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rsi,rax
       mov       rcx,2646E1231D8
       mov       rcx,[rcx]
       mov       rdx,2646E123090
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rsi
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L06
       cmp       dword ptr [rcx+8],0
       je        short M01_L06
       xor       eax,eax
       jmp       short M01_L07
M01_L06:
       mov       eax,1
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B478E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B478E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B478E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 570
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2B0]
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 45
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L05
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
       mov       rdx,1F26B412BA0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,1F24B411568
       mov       r14,[rdx]
       mov       rdx,1F26B412BA8
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L04
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M01_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L03:
       mov       rcx,rdi
       mov       rax,[7FFB52E42180]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rsi,rax
       mov       rcx,1F25B4111E0
       mov       rcx,[rcx]
       mov       rdx,1F25B411098
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rsi
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L06
       cmp       dword ptr [rcx+8],0
       je        short M01_L06
       xor       eax,eax
       jmp       short M01_L07
M01_L06:
       mov       eax,1
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B478E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B478E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B478E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 570
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2B0]
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 45
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L05
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
       mov       rdx,180D18423A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,180C1841568
       mov       r14,[rdx]
       mov       rdx,180D18423A8
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L04
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M01_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L03:
       mov       rcx,rdi
       mov       rax,[7FFB52E12180]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rsi,rax
       mov       rcx,180C18431D8
       mov       rcx,[rcx]
       mov       rdx,180C1843090
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rsi
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L06
       cmp       dword ptr [rcx+8],0
       je        short M01_L06
       xor       eax,eax
       jmp       short M01_L07
M01_L06:
       mov       eax,1
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 570
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2B0]
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 45
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L05
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
       mov       rdx,1E0F63333B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,1E0E6331568
       mov       r14,[rdx]
       mov       rdx,1E0F63333C0
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L04
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M01_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L03:
       mov       rcx,rdi
       mov       rax,[7FFB52E42180]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rsi,rax
       mov       rcx,1E0E63331D8
       mov       rcx,[rcx]
       mov       rdx,1E0E6333090
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rsi
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L06
       cmp       dword ptr [rcx+8],0
       je        short M01_L06
       xor       eax,eax
       jmp       short M01_L07
M01_L06:
       mov       eax,1
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B478E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B478E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B478E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 570
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2B0]
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 45
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L05
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
       mov       rdx,24607D02BA0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,245E7D01568
       mov       r14,[rdx]
       mov       rdx,24607D02BA8
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L04
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M01_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L03:
       mov       rcx,rdi
       mov       rax,[7FFB52E12180]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rsi,rax
       mov       rcx,245E7D031D8
       mov       rcx,[rcx]
       mov       rdx,245E7D03090
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rsi
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L06
       cmp       dword ptr [rcx+8],0
       je        short M01_L06
       xor       eax,eax
       jmp       short M01_L07
M01_L06:
       mov       eax,1
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 570
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.StringBuilderHelperCounterBenchmark.BytesToString()
; 			var result = StringBuilderHelper.BytesToString(this._byteArray);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+2B0]
       call      DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 45
```
```assembly
; DotNetTips.Spargine.Core.StringBuilderHelper.BytesToString(Byte[])
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L05
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
       mov       rdx,22C3ECEAF80
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L01
       mov       rdx,22C3ECE1568
       mov       r14,[rdx]
       mov       rdx,22C3ECEAF88
       mov       r15,[rdx]
M01_L00:
       movsxd    rdx,ebx
       lea       rdx,[rsi+rdx+10]
       mov       r8,r14
       movzx     ecx,byte ptr [rdx]
       mov       rdx,r15
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|42_0(UInt32, System.String, System.IFormatProvider)
       mov       rdx,rax
       mov       rcx,rdi
       call      System.Text.StringBuilder.Append(System.String)
       add       ebx,1
       jo        short M01_L04
       cmp       ebp,ebx
       jg        short M01_L00
M01_L01:
       mov       ecx,[rdi+18]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jbe       short M01_L02
       movsxd    rcx,ecx
       mov       word ptr [rdx+rcx*2+10],27
       inc       dword ptr [rdi+18]
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       edx,27
       mov       r8d,1
       call      System.Text.StringBuilder.Append(Char, Int32)
M01_L03:
       mov       rcx,rdi
       mov       rax,[7FFB52E42180]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       rax
M01_L04:
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rsi,rax
       mov       rcx,22C3ECE31D8
       mov       rcx,[rcx]
       mov       rdx,22C3ECE3090
       mov       rdx,[rdx]
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,rsi
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       je        short M01_L06
       cmp       dword ptr [rcx+8],0
       je        short M01_L06
       xor       eax,eax
       jmp       short M01_L07
M01_L06:
       mov       eax,1
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B478E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B478E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B478E8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 570
```

