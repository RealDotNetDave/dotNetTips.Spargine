Get-ChildItem .\ -include bin,obj,packages,appbin,outputbin -Recurse | foreach ($_) { remove-item $_.fullname -Force -Recurse -Verbose }
dotnet nuget locals all -c