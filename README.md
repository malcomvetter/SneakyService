# SneakyService
A simple C# windows service implementation that can be used to demonstrate privilege escalation from misconfigured windows services.

The current version is only 5KB, built for the .NET 2.0 runtime, and can be used against windows services with unquoted service paths by simply placing it in C:\ and restarting the service. The result is a backdoor administrator account: ehud.
