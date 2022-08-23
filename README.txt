This Tool is for internal use only...
Use it for collecting errors in Console Applications, Web Applications, Web service, WinForm and more...


Database Create Script -> DataAccessLayer -> CreateDatabase.sql

Use this to fix NuGet Package
Update-Package Microsoft.CodeDom.Providers.DotNetCompilerPlatform -r

If problem restor Package:

1) Delete folder "packages"

2) Tools -> NuGet Package Manger -> Package Manager Console

2) Run: Install-Package NuGet.CommandLine i Package Manager Console

Source: 
https://stackoverflow.com/questions/38074578/nuget-has-problems-with-missing-packages-how-to-restore

copy/past in to other Applications try catch:
ErrorLogServices.ErrorLogWSClient client = new ErrorLogServices.ErrorLogWSClient();
client.WriteToLog("[APPLICATION NAME]", ex.Message, ex.Source, ex.StackTrace, url);

-------------------------------------

ErrorLogServices.ErrorLogWSClient client = new ErrorLogServices.ErrorLogWSClient();
client.WriteToMessageLog("[APPLICATION NAME]", "Some message");
