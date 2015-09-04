# SneakyService
A simple C# windows service implementation that can be used to demonstrate privilege escalation from misconfigured windows services.  Download here:

https://github.com/TeeEmmVee/SneakyService/releases/download/1.0/Program.exe

The current version is only 5KB, built for the .NET 2.0 runtime, and can be used against windows services with unquoted service paths by simply placing it in C:\ and restarting the service. The result is a backdoor administrator account: ehud.
