## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.As()
; 			var result = this._person.As<IPerson>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+78]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ObjectExtensions.As(System.Object)
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.As[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 52
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.As[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,218AC433060
       mov       r8,[r8]
       mov       rdx,218BC431130
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[rdi+10]
       mov       rcx,[rcx]
       mov       rdx,rsi
       call      CORINFO_HELP_CHKCASTARRAY
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 74
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.Clone01()
; 			var result = this._person.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+78]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 52
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,22A61173060
       mov       r8,[r8]
       mov       rdx,22A71171130
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB17312228
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr dotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 112
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ComputeSha256Hash01()
; 			var result = this._person.ComputeSha256Hash();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+78]
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       r8,1F80FFA3060
       mov       r8,[r8]
       mov       rdx,1F80FFB2170
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFD8],rdi
       mov       rcx,1F80FFA1AF8
       mov       rdi,[rcx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFB17172BE0]
       mov       rdx,rax
       mov       rcx,[rbp+0FFD8]
       call      System.Security.Cryptography.HashAlgorithm.ComputeHash(Byte[])
       mov       rsi,rax
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
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,1F80FFA1528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1F80FFB2178
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
       inc       ebx
       cmp       r14d,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       call      qword ptr [7FFB17179498]
       mov       rbx,rax
       mov       rcx,[rbp+0FFD8]
       call      qword ptr [7FFB17176A88]
       mov       rax,rbx
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M01_L04
       mov       rcx,[rbp+0FFD8]
       call      qword ptr [7FFB17176A88]
M01_L04:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 364
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ComputeSha256Hash02()
; 			var result = this._personRecord.ComputeSha256Hash();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+80]
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Extensions.ObjectExtensions.ComputeSha256Hash(System.Object)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       r8,1B6529C3060
       mov       r8,[r8]
       mov       rdx,1B6429C1968
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Security.Cryptography.SHA256+Implementation
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.Security.Cryptography.SHA256+Implementation..ctor()
       mov       [rbp+0FFD8],rdi
       mov       rcx,1B6529C1AF8
       mov       rdi,[rcx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFB17172BE0]
       mov       rdx,rax
       mov       rcx,[rbp+0FFD8]
       call      System.Security.Cryptography.HashAlgorithm.ComputeHash(Byte[])
       mov       rsi,rax
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
       xor       ebx,ebx
       mov       r14d,[rsi+8]
       test      r14d,r14d
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,1B6529C1528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1B6429C1970
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
       inc       ebx
       cmp       r14d,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       call      qword ptr [7FFB17179498]
       mov       rbx,rax
       mov       rcx,[rbp+0FFD8]
       call      qword ptr [7FFB17176A88]
       mov       rax,rbx
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M01_L04
       mov       rcx,[rbp+0FFD8]
       call      qword ptr [7FFB17176A88]
M01_L04:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 364
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.DisposeFields()
; 			var disposableType = new DataTable("TEST");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			disposableType.DisposeFields();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rcx,offset MT_System.Data.DataTable
       call      CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rdx,2BDA2481130
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Data.DataTable..ctor(System.String)
       mov       rcx,rsi
       add       rsp,20
       pop       rsi
       jmp       near ptr dotNetTips.Spargine.Extensions.ObjectExtensions.DisposeFields(System.IDisposable)
; Total bytes of code 57
```
```assembly
; System.Data.DataTable..ctor(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       call      System.Data.DataTable..ctor()
       test      rdi,rdi
       je        short M01_L00
       mov       rdx,rdi
       jmp       short M01_L01
M01_L00:
       mov       rdx,2BD72483060
       mov       rdx,[rdx]
M01_L01:
       lea       rcx,[rsi+70]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 60
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.DisposeFields(System.IDisposable)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M02_L00
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       mov       rcx,rsi
       call      00007FFB769A23C0
       mov       rcx,rax
       call      System.Reflection.RuntimeReflectionExtensions.GetRuntimeFields(System.Type)
       mov       rdi,rax
       mov       rcx,7FFB171C6C08
       mov       edx,56
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2BD9248A418
       mov       r8,[rcx]
       test      r8,r8
       jne       short M02_L01
       mov       rcx,offset MT_System.Func`2[[System.Reflection.FieldInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2BD9248A410
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M02_L07
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<DisposeFields>b__4_0(System.Reflection.FieldInfo)
       mov       [rbx+18],rdx
       mov       rcx,2BD9248A418
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M02_L01:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Where(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>)
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToList(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M02_L02
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L02:
       xor       ebx,ebx
       cmp       dword ptr [rdi+10],0
       jle       short M02_L06
M02_L03:
       cmp       ebx,[rdi+10]
       jae       near ptr M02_L08
       mov       rcx,[rdi+8]
       cmp       ebx,[rcx+8]
       jae       short M02_L09
       movsxd    rdx,ebx
       mov       rcx,[rcx+rdx*8+10]
       mov       rdx,rsi
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax]
       mov       rbp,rax
       test      rbp,rbp
       je        short M02_L05
       mov       rdx,rbp
       mov       rcx,offset MT_System.IDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M02_L04
       mov       rcx,rax
       xor       edx,edx
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
       jmp       short M02_L05
M02_L04:
       mov       rdx,rbp
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M02_L05
       mov       rcx,rax
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ProcessCollectionToDispose(System.Collections.IEnumerable)
M02_L05:
       inc       ebx
       cmp       ebx,[rdi+10]
       jl        short M02_L03
M02_L06:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L07:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
M02_L08:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_IndexException()
       int       3
M02_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 388
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.HasProperty()
; 			var result = this._person.HasProperty("City");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+78]
       mov       rdx,14472540990
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 43
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.HasProperty(System.Object, System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,14472531048
       mov       r8,[r8]
       mov       rdx,14472540998
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Func`2[[System.Reflection.PropertyInfo, System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      00007FFB769A23C0
       mov       rcx,rax
       call      System.Reflection.RuntimeReflectionExtensions.GetRuntimeProperties(System.Type)
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass5_0.<HasProperty>b__0(System.Reflection.PropertyInfo)
       mov       [rdi+18],r9
       lea       r9,[rsp+28]
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,Boolean>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>, Boolean ByRef)
       test      rax,rax
       je        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 203
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNotNull()
; 			var result = this._person.IsNotNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rcx+78]
       test      rax,rax
       setne     al
       movzx     eax,al
       mov       rdx,[rcx+10]
       mov       [rdx+44],al
       ret
; Total bytes of code 21
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.IsNull()
; 			var result = this._person.IsNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rcx+78]
       test      rax,rax
       sete      al
       movzx     eax,al
       mov       rdx,[rcx+10]
       mov       [rdx+44],al
       ret
; Total bytes of code 21
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.Duplicate01()
; 			var result = this._personRecord with { Id = "12345678" };
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+80]
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdi,rax
       mov       rdx,1506C295598
       mov       rdx,[rdx]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFB171758B0]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 79
```
```assembly
; dotNetTips.Spargine.Tester.Models.PersonRecord.set_Id(System.String)
; 				if (string.IsNullOrEmpty(value))
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 					throw new ArgumentNullException(nameof(this.Id), "Value for Id cannot be null or empty.");
; 					^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				this._id = value.Length > 256 ? throw new ArgumentOutOfRangeException(nameof(this.Id), "Id length is limited to 256 characters.") : value;
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			}
; 			^
       push      rdi
       push      rsi
       sub       rsp,28
       test      rdx,rdx
       je        short M01_L00
       cmp       dword ptr [rdx+8],0
       jbe       short M01_L00
       cmp       dword ptr [rdx+8],100
       jg        short M01_L01
       lea       rcx,[rcx+30]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,0A7B
       mov       rdx,7FFB17084A80
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0A81
       mov       rdx,7FFB17084A80
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L01:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,0A7B
       mov       rdx,7FFB17084A80
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,0ACD
       mov       rdx,7FFB17084A80
       call      CORINFO_HELP_STRCNS
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 210
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PersonRecordToString01()
; 			var person = this._personRecord;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.ToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+80]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 50
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary01()
; 			var person = this._person;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.PropertiesToDictionary(ignoreNulls: true);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+78]
       mov       rdx,2EEE3163060
       mov       rdx,[rdx]
       mov       r8d,1
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       xor       eax,eax
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FF50],rsp
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       r8,2EEE3163060
       mov       r8,[r8]
       mov       rdx,2EEF3161130
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,2EEE3163060
       mov       r8,[r8]
       mov       rdx,2EEF3161138
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rdi,rdi
       sete      r8b
       movzx     r8d,r8b
       test      r8d,r8d
       je        short M01_L00
       mov       r8,2EEF3161140
       mov       r8,[r8]
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L00:
       mov       rcx,rdi
       call      00007FFB769A23C0
       mov       r15,rax
       mov       rcx,7FFB171A4328
       mov       edx,26
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2EF031681D0
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L01
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L01:
       mov       rcx,r15
       call      dotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       je        near ptr M01_L08
       xor       r15d,r15d
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      CORINFO_HELP_CHKCASTINTERFACE
       mov       rcx,rax
       mov       r11,7FFB16D30510
       call      qword ptr [7FFB17160510]
       mov       [rbp+0FF88],rax
       mov       rcx,[rbp+0FF88]
       mov       r11,7FFB16D30518
       call      qword ptr [7FFB17160518]
       test      eax,eax
       je        near ptr M01_L06
M01_L02:
       mov       rcx,[rbp+0FF88]
       mov       r11,7FFB16D30520
       call      qword ptr [7FFB17160520]
       mov       rdi,rax
       lea       ecx,[r15+1]
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       [r12+8],r15d
       xor       edx,edx
       mov       r8,2EEE3161360
       mov       r8,[r8]
       mov       rax,2EEF3161148
       mov       rax,[rax]
       lea       r9,[rbp+0FF90]
       mov       [r9],rsi
       mov       [r9+8],r12
       mov       [r9+10],rdx
       mov       [r9+18],r8
       mov       rdx,rax
       lea       r8,[rbp+0FF90]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       rcx,7FFB171A6C08
       mov       edx,56
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2EF03168408
       mov       r14,[rcx]
       test      r14,r14
       jne       short M01_L03
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,2EF031683F8
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L05
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__9_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r14+18],rdx
       mov       rcx,2EF03168408
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L03:
       mov       rcx,2EF03168410
       mov       r9,[rcx]
       test      r9,r9
       jne       short M01_L04
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,2EF031683F8
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M01_L05
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__9_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r15+18],rdx
       mov       rcx,2EF03168410
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r9,r15
M01_L04:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r14
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Func`2<!!0,!!2>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       call      System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       rcx,[rbp+0FF88]
       mov       r11,7FFB16D30518
       call      qword ptr [7FFB17160518]
       test      eax,eax
       mov       r15d,ebx
       jne       near ptr M01_L02
       jmp       short M01_L06
M01_L05:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
M01_L06:
       mov       rdx,[rbp+0FF88]
       mov       rcx,offset MT_System.IDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L07
       mov       rcx,rax
       mov       r11,7FFB16D30528
       call      qword ptr [7FFB17160528]
M01_L07:
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L08:
       cmp       [r15],r15d
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp+0FFB0]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       lea       rcx,[rbp+0FFB0]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       r15,rax
       mov       rdx,2EEE3163060
       mov       r12,[rdx]
       cmp       dword ptr [rsi+8],0
       jle       short M01_L09
       mov       rdx,2EEE3163128
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.String.Concat(System.String, System.String)
       mov       r12,rax
M01_L09:
       xor       esi,esi
       mov       r13d,[r15+8]
       test      r13d,r13d
       jle       near ptr M01_L15
M01_L10:
       movsxd    rcx,esi
       mov       rax,[r15+rcx*8+10]
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       mov       [rbp+0FF80],rax
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+30]
       test      bl,bl
       je        near ptr M01_L17
       mov       [rbp+0FF78],rax
       test      rax,rax
       je        near ptr M01_L14
M01_L11:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       [rbp+0FF70],rax
       mov       rcx,[rbp+0FF80]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,r12
       xor       edx,edx
       mov       r8,2EEE3161360
       mov       r8,[r8]
       mov       r9,[rbp+0FF70]
       mov       r10,2EEF3161150
       mov       r10,[r10]
       lea       r11,[rbp+0FF90]
       mov       [r11],rcx
       mov       [r11+8],rax
       mov       [r11+10],rdx
       mov       [r11+18],r8
       mov       rcx,r9
       mov       rdx,r10
       lea       r8,[rbp+0FF90]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,[rbp+0FF78]
       mov       r8d,1
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       r14,rax
       mov       rcx,7FFB171A6C08
       mov       edx,56
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2EF03168418
       mov       rax,[rcx]
       test      rax,rax
       jne       short M01_L12
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,2EF031683F8
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L18
       mov       [rbp+0FF58],rax
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__9_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp+0FF58]
       mov       [rax+18],rdx
       mov       rcx,2EF03168418
       mov       [rbp+0FF58],rax
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+0FF58]
M01_L12:
       mov       rcx,2EF03168420
       mov       r9,[rcx]
       mov       [rbp+0FF68],rax
       test      r9,r9
       jne       near ptr M01_L16
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       rdx,2EF031683F8
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L18
       mov       [rbp+0FF60],r9
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__9_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp+0FF60]
       mov       [r9+18],rdx
       mov       rcx,2EF03168420
       mov       [rbp+0FF60],r9
       mov       rdx,r9
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r9,[rbp+0FF60]
       mov       rax,[rbp+0FF68]
M01_L13:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Func`2<!!0,!!2>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       call      System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M01_L14:
       inc       esi
       cmp       r13d,esi
       jg        near ptr M01_L10
M01_L15:
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L16:
       mov       rax,[rbp+0FF68]
       jmp       short M01_L13
M01_L17:
       mov       [rbp+0FF78],rax
       jmp       near ptr M01_L11
M01_L18:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+0E0]
       mov       rdx,[rbp+0FF88]
       mov       rcx,offset MT_System.IDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L19
       mov       rcx,rax
       mov       r11,7FFB16D30528
       call      qword ptr [7FFB17160528]
M01_L19:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1728
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary02()
; 			var person = this._person;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.PropertiesToDictionary(ignoreNulls: false);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+78]
       mov       rdx,25020CF3060
       mov       rdx,[rdx]
       xor       r8d,r8d
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       xor       eax,eax
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FF50],rsp
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       r8,25020CF3060
       mov       r8,[r8]
       mov       rdx,25030CFDD08
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,25020CF3060
       mov       r8,[r8]
       mov       rdx,25030CFDD10
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rdi,rdi
       sete      r8b
       movzx     r8d,r8b
       test      r8d,r8d
       je        short M01_L00
       mov       r8,25030CFDD18
       mov       r8,[r8]
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L00:
       mov       rcx,rdi
       call      00007FFB769A23C0
       mov       r15,rax
       mov       rcx,7FFB171A4328
       mov       edx,26
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,25030CF81D0
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L01
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L01:
       mov       rcx,r15
       call      dotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       je        near ptr M01_L08
       xor       r15d,r15d
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      CORINFO_HELP_CHKCASTINTERFACE
       mov       rcx,rax
       mov       r11,7FFB16D30510
       call      qword ptr [7FFB17160510]
       mov       [rbp+0FF88],rax
       mov       rcx,[rbp+0FF88]
       mov       r11,7FFB16D30518
       call      qword ptr [7FFB17160518]
       test      eax,eax
       je        near ptr M01_L06
M01_L02:
       mov       rcx,[rbp+0FF88]
       mov       r11,7FFB16D30520
       call      qword ptr [7FFB17160520]
       mov       rdi,rax
       lea       ecx,[r15+1]
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       [r12+8],r15d
       xor       edx,edx
       mov       r8,25020CF1360
       mov       r8,[r8]
       mov       rax,25030CFDD20
       mov       rax,[rax]
       lea       r9,[rbp+0FF90]
       mov       [r9],rsi
       mov       [r9+8],r12
       mov       [r9+10],rdx
       mov       [r9+18],r8
       mov       rdx,rax
       lea       r8,[rbp+0FF90]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       rcx,7FFB171A6C08
       mov       edx,56
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,25030CF8408
       mov       r14,[rcx]
       test      r14,r14
       jne       short M01_L03
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,25030CF83F8
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L05
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__9_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r14+18],rdx
       mov       rcx,25030CF8408
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L03:
       mov       rcx,25030CF8410
       mov       r9,[rcx]
       test      r9,r9
       jne       short M01_L04
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,25030CF83F8
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M01_L05
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__9_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r15+18],rdx
       mov       rcx,25030CF8410
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r9,r15
M01_L04:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r14
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Func`2<!!0,!!2>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       call      System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       rcx,[rbp+0FF88]
       mov       r11,7FFB16D30518
       call      qword ptr [7FFB17160518]
       test      eax,eax
       mov       r15d,ebx
       jne       near ptr M01_L02
       jmp       short M01_L06
M01_L05:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
M01_L06:
       mov       rdx,[rbp+0FF88]
       mov       rcx,offset MT_System.IDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L07
       mov       rcx,rax
       mov       r11,7FFB16D30528
       call      qword ptr [7FFB17160528]
M01_L07:
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L08:
       cmp       [r15],r15d
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp+0FFB0]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       lea       rcx,[rbp+0FFB0]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       r15,rax
       mov       rdx,25020CF3060
       mov       r12,[rdx]
       cmp       dword ptr [rsi+8],0
       jle       short M01_L09
       mov       rdx,25020CF3128
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.String.Concat(System.String, System.String)
       mov       r12,rax
M01_L09:
       xor       esi,esi
       mov       r13d,[r15+8]
       test      r13d,r13d
       jle       near ptr M01_L15
M01_L10:
       movsxd    rcx,esi
       mov       rax,[r15+rcx*8+10]
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       mov       [rbp+0FF80],rax
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+30]
       test      bl,bl
       je        near ptr M01_L17
       mov       [rbp+0FF78],rax
       test      rax,rax
       je        near ptr M01_L14
M01_L11:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       [rbp+0FF70],rax
       mov       rcx,[rbp+0FF80]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,r12
       xor       edx,edx
       mov       r8,25020CF1360
       mov       r8,[r8]
       mov       r9,[rbp+0FF70]
       mov       r10,25030CFDD28
       mov       r10,[r10]
       lea       r11,[rbp+0FF90]
       mov       [r11],rcx
       mov       [r11+8],rax
       mov       [r11+10],rdx
       mov       [r11+18],r8
       mov       rcx,r9
       mov       rdx,r10
       lea       r8,[rbp+0FF90]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,[rbp+0FF78]
       mov       r8d,1
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       r14,rax
       mov       rcx,7FFB171A6C08
       mov       edx,56
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,25030CF8418
       mov       rax,[rcx]
       test      rax,rax
       jne       short M01_L12
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,25030CF83F8
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L18
       mov       [rbp+0FF58],rax
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__9_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp+0FF58]
       mov       [rax+18],rdx
       mov       rcx,25030CF8418
       mov       [rbp+0FF58],rax
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+0FF58]
M01_L12:
       mov       rcx,25030CF8420
       mov       r9,[rcx]
       mov       [rbp+0FF68],rax
       test      r9,r9
       jne       near ptr M01_L16
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       rdx,25030CF83F8
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L18
       mov       [rbp+0FF60],r9
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__9_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp+0FF60]
       mov       [r9+18],rdx
       mov       rcx,25030CF8420
       mov       [rbp+0FF60],r9
       mov       rdx,r9
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r9,[rbp+0FF60]
       mov       rax,[rbp+0FF68]
M01_L13:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Func`2<!!0,!!2>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       call      System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M01_L14:
       inc       esi
       cmp       r13d,esi
       jg        near ptr M01_L10
M01_L15:
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L16:
       mov       rax,[rbp+0FF68]
       jmp       short M01_L13
M01_L17:
       mov       [rbp+0FF78],rax
       jmp       near ptr M01_L11
M01_L18:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+0E0]
       mov       rdx,[rbp+0FF88]
       mov       rcx,offset MT_System.IDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L19
       mov       rcx,rax
       mov       r11,7FFB16D30528
       call      qword ptr [7FFB17160528]
M01_L19:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1728
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary05()
; 			var person = this._personRecord;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.PropertiesToDictionary(ignoreNulls: true);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+80]
       mov       rdx,1B049283060
       mov       rdx,[rdx]
       mov       r8d,1
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       xor       eax,eax
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FF50],rsp
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       r8,1B049283060
       mov       r8,[r8]
       mov       rdx,1B049285598
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1B049283060
       mov       r8,[r8]
       mov       rdx,1B0492855A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rdi,rdi
       sete      r8b
       movzx     r8d,r8b
       test      r8d,r8d
       je        short M01_L00
       mov       r8,1B0492855A8
       mov       r8,[r8]
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L00:
       mov       rcx,rdi
       call      00007FFB769A23C0
       mov       r15,rax
       mov       rcx,7FFB171D4328
       mov       edx,26
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1B0392881D0
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L01
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L01:
       mov       rcx,r15
       call      dotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       je        near ptr M01_L08
       xor       r15d,r15d
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      CORINFO_HELP_CHKCASTINTERFACE
       mov       rcx,rax
       mov       r11,7FFB16D60510
       call      qword ptr [7FFB17190510]
       mov       [rbp+0FF88],rax
       mov       rcx,[rbp+0FF88]
       mov       r11,7FFB16D60518
       call      qword ptr [7FFB17190518]
       test      eax,eax
       je        near ptr M01_L06
M01_L02:
       mov       rcx,[rbp+0FF88]
       mov       r11,7FFB16D60520
       call      qword ptr [7FFB17190520]
       mov       rdi,rax
       lea       ecx,[r15+1]
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       [r12+8],r15d
       xor       edx,edx
       mov       r8,1B049281360
       mov       r8,[r8]
       mov       rax,1B0492855B0
       mov       rax,[rax]
       lea       r9,[rbp+0FF90]
       mov       [r9],rsi
       mov       [r9+8],r12
       mov       [r9+10],rdx
       mov       [r9+18],r8
       mov       rdx,rax
       lea       r8,[rbp+0FF90]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       rcx,7FFB171D6C08
       mov       edx,56
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1B039288408
       mov       r14,[rcx]
       test      r14,r14
       jne       short M01_L03
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1B0392883F8
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L05
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__9_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r14+18],rdx
       mov       rcx,1B039288408
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L03:
       mov       rcx,1B039288410
       mov       r9,[rcx]
       test      r9,r9
       jne       short M01_L04
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,1B0392883F8
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M01_L05
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__9_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r15+18],rdx
       mov       rcx,1B039288410
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r9,r15
M01_L04:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r14
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Func`2<!!0,!!2>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       call      System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       rcx,[rbp+0FF88]
       mov       r11,7FFB16D60518
       call      qword ptr [7FFB17190518]
       test      eax,eax
       mov       r15d,ebx
       jne       near ptr M01_L02
       jmp       short M01_L06
M01_L05:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
M01_L06:
       mov       rdx,[rbp+0FF88]
       mov       rcx,offset MT_System.IDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L07
       mov       rcx,rax
       mov       r11,7FFB16D60528
       call      qword ptr [7FFB17190528]
M01_L07:
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L08:
       cmp       [r15],r15d
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp+0FFB0]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       lea       rcx,[rbp+0FFB0]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       r15,rax
       mov       rdx,1B049283060
       mov       r12,[rdx]
       cmp       dword ptr [rsi+8],0
       jle       short M01_L09
       mov       rdx,1B049283128
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.String.Concat(System.String, System.String)
       mov       r12,rax
M01_L09:
       xor       esi,esi
       mov       r13d,[r15+8]
       test      r13d,r13d
       jle       near ptr M01_L15
M01_L10:
       movsxd    rcx,esi
       mov       rax,[r15+rcx*8+10]
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       mov       [rbp+0FF80],rax
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+30]
       test      bl,bl
       je        near ptr M01_L17
       mov       [rbp+0FF78],rax
       test      rax,rax
       je        near ptr M01_L14
M01_L11:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       [rbp+0FF70],rax
       mov       rcx,[rbp+0FF80]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,r12
       xor       edx,edx
       mov       r8,1B049281360
       mov       r8,[r8]
       mov       r9,[rbp+0FF70]
       mov       r10,1B0492855B8
       mov       r10,[r10]
       lea       r11,[rbp+0FF90]
       mov       [r11],rcx
       mov       [r11+8],rax
       mov       [r11+10],rdx
       mov       [r11+18],r8
       mov       rcx,r9
       mov       rdx,r10
       lea       r8,[rbp+0FF90]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,[rbp+0FF78]
       mov       r8d,1
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       r14,rax
       mov       rcx,7FFB171D6C08
       mov       edx,56
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1B039288418
       mov       rax,[rcx]
       test      rax,rax
       jne       short M01_L12
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,1B0392883F8
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L18
       mov       [rbp+0FF58],rax
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__9_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp+0FF58]
       mov       [rax+18],rdx
       mov       rcx,1B039288418
       mov       [rbp+0FF58],rax
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+0FF58]
M01_L12:
       mov       rcx,1B039288420
       mov       r9,[rcx]
       mov       [rbp+0FF68],rax
       test      r9,r9
       jne       near ptr M01_L16
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       rdx,1B0392883F8
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L18
       mov       [rbp+0FF60],r9
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__9_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp+0FF60]
       mov       [r9+18],rdx
       mov       rcx,1B039288420
       mov       [rbp+0FF60],r9
       mov       rdx,r9
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r9,[rbp+0FF60]
       mov       rax,[rbp+0FF68]
M01_L13:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Func`2<!!0,!!2>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       call      System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M01_L14:
       inc       esi
       cmp       r13d,esi
       jg        near ptr M01_L10
M01_L15:
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L16:
       mov       rax,[rbp+0FF68]
       jmp       short M01_L13
M01_L17:
       mov       [rbp+0FF78],rax
       jmp       near ptr M01_L11
M01_L18:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+0E0]
       mov       rdx,[rbp+0FF88]
       mov       rcx,offset MT_System.IDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L19
       mov       rcx,rax
       mov       r11,7FFB16D60528
       call      qword ptr [7FFB17190528]
M01_L19:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1728
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToDictionary04()
; 			var person = this._personRecord;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.PropertiesToDictionary(ignoreNulls: false);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+80]
       mov       rdx,260C2693060
       mov       rdx,[rdx]
       xor       r8d,r8d
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FF90],xmm4
       vmovdqa   xmmword ptr [rbp+0FFA0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       xor       eax,eax
       mov       [rbp+0FFC0],rax
       mov       [rbp+0FF50],rsp
       mov       rdi,rcx
       mov       rsi,rdx
       mov       ebx,r8d
       mov       r8,260C2693060
       mov       r8,[r8]
       mov       rdx,260D2691130
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,260C2693060
       mov       r8,[r8]
       mov       rdx,260D2691138
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,offset MT_System.Collections.Generic.Dictionary`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       xor       r8d,r8d
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(Int32, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       test      rdi,rdi
       sete      r8b
       movzx     r8d,r8b
       test      r8d,r8d
       je        short M01_L00
       mov       r8,260D2691140
       mov       r8,[r8]
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L00:
       mov       rcx,rdi
       call      00007FFB769A23C0
       mov       r15,rax
       mov       rcx,7FFB171D4328
       mov       edx,26
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,260C269C638
       mov       rcx,[rcx]
       cmp       [rcx],ecx
       mov       rdx,r15
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].FindValue(System.__Canon)
       test      rax,rax
       je        short M01_L01
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       r8,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r9d,2
       call      System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L01:
       mov       rcx,r15
       call      dotNetTips.Spargine.Extensions.TypeExtensions.IsEnumerable(System.Type)
       test      eax,eax
       je        near ptr M01_L08
       xor       r15d,r15d
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.IEnumerable
       call      CORINFO_HELP_CHKCASTINTERFACE
       mov       rcx,rax
       mov       r11,7FFB16D60510
       call      qword ptr [7FFB17190510]
       mov       [rbp+0FF88],rax
       mov       rcx,[rbp+0FF88]
       mov       r11,7FFB16D60518
       call      qword ptr [7FFB17190518]
       test      eax,eax
       je        near ptr M01_L06
M01_L02:
       mov       rcx,[rbp+0FF88]
       mov       r11,7FFB16D60520
       call      qword ptr [7FFB17190520]
       mov       rdi,rax
       lea       ecx,[r15+1]
       mov       ebx,ecx
       mov       rcx,offset MT_System.Int32
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       [r12+8],r15d
       xor       edx,edx
       mov       r8,260C2691360
       mov       r8,[r8]
       mov       rax,260D2691148
       mov       rax,[rax]
       lea       r9,[rbp+0FF90]
       mov       [r9],rsi
       mov       [r9+8],r12
       mov       [r9+10],rdx
       mov       [r9+18],r8
       mov       rdx,rax
       lea       r8,[rbp+0FF90]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,rdi
       mov       r8d,1
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       rdi,rax
       mov       rcx,7FFB171D6C08
       mov       edx,56
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,260C269C870
       mov       r14,[rcx]
       test      r14,r14
       jne       short M01_L03
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,260C269C860
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L05
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__9_0(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r14+18],rdx
       mov       rcx,260C269C870
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M01_L03:
       mov       rcx,260C269C878
       mov       r9,[rcx]
       test      r9,r9
       jne       short M01_L04
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,260C269C860
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M01_L05
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__9_1(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [r15+18],rdx
       mov       rcx,260C269C878
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r9,r15
M01_L04:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,rdi
       mov       r8,r14
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Func`2<!!0,!!2>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       call      System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
       mov       rcx,[rbp+0FF88]
       mov       r11,7FFB16D60518
       call      qword ptr [7FFB17190518]
       test      eax,eax
       mov       r15d,ebx
       jne       near ptr M01_L02
       jmp       short M01_L06
M01_L05:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
M01_L06:
       mov       rdx,[rbp+0FF88]
       mov       rcx,offset MT_System.IDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L07
       mov       rcx,rax
       mov       r11,7FFB16D60528
       call      qword ptr [7FFB17190528]
M01_L07:
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L08:
       cmp       [r15],r15d
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp+0FFB0]
       mov       rcx,r15
       xor       r8d,r8d
       mov       r9d,1C
       call      System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       lea       rcx,[rbp+0FFB0]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder`1[[System.Reflection.PropertyInfo, System.Private.CoreLib]]
       call      System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       r15,rax
       mov       rdx,260C2693060
       mov       r12,[rdx]
       cmp       dword ptr [rsi+8],0
       jle       short M01_L09
       mov       rdx,260C2693128
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.String.Concat(System.String, System.String)
       mov       r12,rax
M01_L09:
       xor       esi,esi
       mov       r13d,[r15+8]
       test      r13d,r13d
       jle       near ptr M01_L15
M01_L10:
       movsxd    rcx,esi
       mov       rax,[r15+rcx*8+10]
       mov       rcx,rax
       mov       rdx,rdi
       xor       r8d,r8d
       mov       [rbp+0FF80],rax
       mov       r9,[rax]
       mov       r9,[r9+58]
       call      qword ptr [r9+30]
       test      bl,bl
       je        near ptr M01_L17
       mov       [rbp+0FF78],rax
       test      rax,rax
       je        near ptr M01_L14
M01_L11:
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       mov       [rbp+0FF70],rax
       mov       rcx,[rbp+0FF80]
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rcx,r12
       xor       edx,edx
       mov       r8,260C2691360
       mov       r8,[r8]
       mov       r9,[rbp+0FF70]
       mov       r10,260D2691150
       mov       r10,[r10]
       lea       r11,[rbp+0FF90]
       mov       [r11],rcx
       mov       [r11+8],rax
       mov       [r11+10],rdx
       mov       [r11+18],r8
       mov       rcx,r9
       mov       rdx,r10
       lea       r8,[rbp+0FF90]
       call      System.String.FormatHelper(System.IFormatProvider, System.String, System.ParamsArray)
       mov       rdx,rax
       mov       rcx,[rbp+0FF78]
       mov       r8d,1
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       r8,rax
       mov       rdx,r14
       mov       rcx,offset MD_System.Linq.Enumerable.Concat(System.Collections.Generic.IEnumerable`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.Concat[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>)
       mov       r14,rax
       mov       rcx,7FFB171D6C08
       mov       edx,56
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,260C269C880
       mov       rax,[rcx]
       test      rax,rax
       jne       short M01_L12
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,260C269C860
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L18
       mov       [rbp+0FF58],rax
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__9_2(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       rax,[rbp+0FF58]
       mov       [rax+18],rdx
       mov       rcx,260C269C880
       mov       [rbp+0FF58],rax
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp+0FF58]
M01_L12:
       mov       rcx,260C269C888
       mov       r9,[rcx]
       mov       [rbp+0FF68],rax
       test      r9,r9
       jne       near ptr M01_L16
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       r9,rax
       mov       rdx,260C269C860
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M01_L18
       mov       [rbp+0FF60],r9
       lea       rcx,[r9+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c.<PropertiesToDictionary>b__9_3(System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       r9,[rbp+0FF60]
       mov       [r9+18],rdx
       mov       rcx,260C269C888
       mov       [rbp+0FF60],r9
       mov       rdx,r9
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r9,[rbp+0FF60]
       mov       rax,[rbp+0FF68]
M01_L13:
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToDictionary(System.Collections.Generic.IEnumerable`1<!!0>, System.Func`2<!!0,!!1>, System.Func`2<!!0,!!2>, System.Collections.Generic.IEqualityComparer`1<!!1>)
       call      System.Linq.Enumerable.ToDictionary[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>, System.Collections.Generic.IEqualityComparer`1<System.__Canon>)
       mov       r14,rax
M01_L14:
       inc       esi
       cmp       r13d,esi
       jg        near ptr M01_L10
M01_L15:
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L16:
       mov       rax,[rbp+0FF68]
       jmp       short M01_L13
M01_L17:
       mov       [rbp+0FF78],rax
       jmp       near ptr M01_L11
M01_L18:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+0E0]
       mov       rdx,[rbp+0FF88]
       mov       rcx,offset MT_System.IDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M01_L19
       mov       rcx,rax
       mov       r11,7FFB16D60528
       call      qword ptr [7FFB17190528]
M01_L19:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1728
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString01()
; 			var person = this._person;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.PropertiesToString(ignoreNulls: true);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+78]
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       r9,274737712C8
       mov       r9,[r9]
       mov       rdx,27493771048
       mov       rdx,[rdx]
       mov       r8d,3A
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 90
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebp,r8d
       mov       rbx,r9
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+10],bp
       mov       r8,27493771048
       mov       r8,[r8]
       mov       rdx,2748377FD20
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,27493771048
       mov       r8,[r8]
       mov       rdx,2748377FD28
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r14+8]
       mov       rdx,2748377FD30
       mov       rdx,[rdx]
       mov       r8,27493771048
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       call      00007FFB769A23C0
       mov       rcx,rax
       xor       edx,edx
       call      System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rbx,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       xor       edx,edx
       call      System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.String.Equals(System.String, System.String)
       test      eax,eax
       je        short M01_L00
       mov       r8,2748377FD38
       mov       rbx,[r8]
       jmp       short M01_L01
M01_L00:
       cmp       byte ptr [rsp+78],0
       jne       short M01_L01
       mov       r8,27493771048
       mov       rbx,[r8]
M01_L01:
       mov       ebp,[rsp+70]
       movzx     r8d,bpl
       mov       rcx,rsi
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rsi,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass10_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rbx+18],r9
       mov       r9,rbx
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate(System.Collections.Generic.IEnumerable`1<!!0>, !!1, System.Func`3<!!1,!!0,!!1>)
       call      System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[r14+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       jne       short M01_L02
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       r8,[r14+8]
       mov       r8d,[r8+8]
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.String.Remove(Int32, Int32)
; Total bytes of code 412
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString02()
; 			var person = this._person;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.PropertiesToString(ignoreNulls: false);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+78]
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       dword ptr [rsp+28],1
       mov       r9,1C7D7C112C8
       mov       r9,[r9]
       mov       rdx,1C7F7C13060
       mov       rdx,[rdx]
       mov       r8d,3A
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 90
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebp,r8d
       mov       rbx,r9
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+10],bp
       mov       r8,1C7F7C13060
       mov       r8,[r8]
       mov       rdx,1C807C11130
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1C7F7C13060
       mov       r8,[r8]
       mov       rdx,1C807C11138
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r14+8]
       mov       rdx,1C807C11140
       mov       rdx,[rdx]
       mov       r8,1C7F7C13060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       call      00007FFB769A23C0
       mov       rcx,rax
       xor       edx,edx
       call      System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rbx,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       xor       edx,edx
       call      System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.String.Equals(System.String, System.String)
       test      eax,eax
       je        short M01_L00
       mov       r8,1C807C11148
       mov       rbx,[r8]
       jmp       short M01_L01
M01_L00:
       cmp       byte ptr [rsp+78],0
       jne       short M01_L01
       mov       r8,1C7F7C13060
       mov       rbx,[r8]
M01_L01:
       mov       ebp,[rsp+70]
       movzx     r8d,bpl
       mov       rcx,rsi
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rsi,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass10_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rbx+18],r9
       mov       r9,rbx
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate(System.Collections.Generic.IEnumerable`1<!!0>, !!1, System.Func`3<!!1,!!0,!!1>)
       call      System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[r14+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       jne       short M01_L02
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       r8,[r14+8]
       mov       r8d,[r8+8]
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.String.Remove(Int32, Int32)
; Total bytes of code 412
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString03()
; 			var person = this._personRecord;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.PropertiesToString(ignoreNulls: true);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+80]
       mov       dword ptr [rsp+20],1
       mov       dword ptr [rsp+28],1
       mov       r9,1FCAAFE12C8
       mov       r9,[r9]
       mov       rdx,1FCCAFE3060
       mov       rdx,[rdx]
       mov       r8d,3A
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 93
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebp,r8d
       mov       rbx,r9
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+10],bp
       mov       r8,1FCCAFE3060
       mov       r8,[r8]
       mov       rdx,1FCBAFE1130
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,1FCCAFE3060
       mov       r8,[r8]
       mov       rdx,1FCBAFE1138
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r14+8]
       mov       rdx,1FCBAFE1140
       mov       rdx,[rdx]
       mov       r8,1FCCAFE3060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       call      00007FFB769A23C0
       mov       rcx,rax
       xor       edx,edx
       call      System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rbx,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       xor       edx,edx
       call      System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.String.Equals(System.String, System.String)
       test      eax,eax
       je        short M01_L00
       mov       r8,1FCBAFE1148
       mov       rbx,[r8]
       jmp       short M01_L01
M01_L00:
       cmp       byte ptr [rsp+78],0
       jne       short M01_L01
       mov       r8,1FCCAFE3060
       mov       rbx,[r8]
M01_L01:
       mov       ebp,[rsp+70]
       movzx     r8d,bpl
       mov       rcx,rsi
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rsi,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass10_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rbx+18],r9
       mov       r9,rbx
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate(System.Collections.Generic.IEnumerable`1<!!0>, !!1, System.Func`3<!!1,!!0,!!1>)
       call      System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[r14+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       jne       short M01_L02
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       r8,[r14+8]
       mov       r8d,[r8+8]
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.String.Remove(Int32, Int32)
; Total bytes of code 412
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.PropertiesToString04()
; 			var person = this._personRecord;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = person.PropertiesToString(ignoreNulls: false);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+80]
       xor       r9d,r9d
       mov       [rsp+20],r9d
       mov       dword ptr [rsp+28],1
       mov       r9,26E89193718
       mov       r9,[r9]
       mov       rdx,26E89193060
       mov       rdx,[rdx]
       mov       r8d,3A
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 93
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToString(System.Object, System.String, Char, System.String, Boolean, Boolean)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebp,r8d
       mov       rbx,r9
       mov       rcx,offset MT_dotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r14+10],bp
       mov       r8,26E89193060
       mov       r8,[r8]
       mov       rdx,26EB9191130
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       r8,26E89193060
       mov       r8,[r8]
       mov       rdx,26EB9191138
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,[r14+8]
       mov       rdx,26EB9191140
       mov       rdx,[rdx]
       mov       r8,26E89193060
       mov       r8,[r8]
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       call      00007FFB769A23C0
       mov       rcx,rax
       xor       edx,edx
       call      System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rbx,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       xor       edx,edx
       call      System.RuntimeType.GetCachedName(System.TypeNameKind)
       mov       rdx,rax
       mov       rcx,rbx
       call      System.String.Equals(System.String, System.String)
       test      eax,eax
       je        short M01_L00
       mov       r8,26EB9191148
       mov       rbx,[r8]
       jmp       short M01_L01
M01_L00:
       cmp       byte ptr [rsp+78],0
       jne       short M01_L01
       mov       r8,26E89193060
       mov       rbx,[r8]
M01_L01:
       mov       ebp,[rsp+70]
       movzx     r8d,bpl
       mov       rcx,rsi
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.PropertiesToDictionary(System.Object, System.String, Boolean)
       mov       rsi,rax
       mov       rcx,offset MT_System.Func`3[[System.String, System.Private.CoreLib],[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[System.String, System.Private.CoreLib]], System.Private.CoreLib],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,offset dotNetTips.Spargine.Extensions.ObjectExtensions+<>c__DisplayClass10_0.<PropertiesToString>b__0(System.String, System.Collections.Generic.KeyValuePair`2<System.String,System.String>)
       mov       [rbx+18],r9
       mov       r9,rbx
       mov       rdx,rsi
       mov       r8,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Aggregate(System.Collections.Generic.IEnumerable`1<!!0>, !!1, System.Func`3<!!1,!!0,!!1>)
       call      System.Linq.Enumerable.Aggregate[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.__Canon, System.Func`3<System.__Canon,System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,System.__Canon>)
       mov       rsi,rax
       mov       rdx,[r14+8]
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      System.String.StartsWith(System.String, System.StringComparison)
       test      eax,eax
       jne       short M01_L02
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       mov       r8,[r14+8]
       mov       r8d,[r8+8]
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.String.Remove(Int32, Int32)
; Total bytes of code 412
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.StripNull()
; 			var result = this._person.StripNull();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+78]
       test      rcx,rcx
       je        short M00_L00
       call      qword ptr [7FFB171549B8]
       jmp       short M00_L01
M00_L00:
       mov       rax,2ED054F3060
       mov       rax,[rax]
M00_L01:
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; dotNetTips.Spargine.Tester.Models.PersonProper.ToString()
; 		public override string ToString() => this.Id.ToString(CultureInfo.CurrentCulture);
; 		                                     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,[rcx+48]
       call      System.Globalization.CultureInfo.get_CurrentCulture()
       cmp       [rsi],esi
       mov       rax,rsi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 25
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ToJson01()
; 			var result = this._person.ToJson();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+78]
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       test      rcx,rcx
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L00
       mov       rax,254624F3060
       mov       rax,[rax]
       ret
M01_L00:
       mov       rdx,rcx
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.Serialize(!!0, System.Text.Json.JsonSerializerOptions)
       xor       r8d,r8d
       jmp       near ptr System.Text.Json.JsonSerializer.Serialize[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Text.Json.JsonSerializerOptions)
; Total bytes of code 48
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.ToJson02()
; 			var result = this._personRecord.ToJson();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+80]
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       test      rcx,rcx
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L00
       mov       rax,27728123060
       mov       rax,[rax]
       ret
M01_L00:
       mov       rdx,rcx
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.Serialize(!!0, System.Text.Json.JsonSerializerOptions)
       xor       r8d,r8d
       jmp       near ptr System.Text.Json.JsonSerializer.Serialize[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Text.Json.JsonSerializerOptions)
; Total bytes of code 48
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ObjectExtensionsBenchmark.TryDispose()
; 			var disposableType = new DataTable("TEST");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			disposableType.TryDispose();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rcx,offset MT_System.Data.DataTable
       call      CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rdx,26EB3751968
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Data.DataTable..ctor(System.String)
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,20
       pop       rsi
       jmp       near ptr dotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
; Total bytes of code 59
```
```assembly
; System.Data.DataTable..ctor(System.String)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,rsi
       call      System.Data.DataTable..ctor()
       test      rdi,rdi
       je        short M01_L00
       mov       rdx,rdi
       jmp       short M01_L01
M01_L00:
       mov       rdx,26EA3753060
       mov       rdx,[rdx]
M01_L01:
       lea       rcx,[rsi+70]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 60
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.TryDispose(System.IDisposable, Boolean)
       push      rbp
       push      rsi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFF0],rax
       mov       [rbp+0FFE0],rsp
       mov       [rbp+18],edx
       mov       rsi,rcx
       test      rsi,rsi
       sete      dl
       movzx     edx,dl
       test      edx,edx
       je        short M02_L00
       lea       rsp,[rbp+0FFF8]
       pop       rsi
       pop       rbp
       ret
M02_L00:
       mov       rdx,rsi
       mov       rcx,offset MT_System.IAsyncDisposable
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       test      rax,rax
       je        short M02_L01
       lea       rdx,[rbp+0FFE8]
       mov       rcx,rax
       mov       r11,7FFB16D40548
       call      qword ptr [7FFB17170548]
       jmp       short M02_L02
M02_L01:
       mov       rcx,rsi
       mov       r11,7FFB16D40540
       call      qword ptr [7FFB17170540]
       nop
M02_L02:
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
       cmp       byte ptr [rbp+18],0
       je        short M02_L03
       call      CORINFO_HELP_RETHROW
M02_L03:
       lea       rax,[7FFB17178157]
       add       rsp,28
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 170
```

