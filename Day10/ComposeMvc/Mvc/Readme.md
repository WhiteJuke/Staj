## Nuget paketleri
- dotnet tool uninstall --global dotnet-aspnet-codegenerator
- dotnet tool install --global dotnet-aspnet-codegenerator
- dotnet tool uninstall --global dotnet-ef
- dotnet tool install --global dotnet-ef
- dotnet add package Microsoft.EntityFrameworkCore.Design
- dotnet add package Microsoft.EntityFrameworkCore.SQLite
- dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
- dotnet add package Microsoft.EntityFrameworkCore.SqlServer nuget paketleri




## Scaffolding örneği
- dotnet-aspnet-codegenerator controller -name MoviesController -m Movie -dc MvcMovieContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite

- -m 	The name of the model.
- -dc 	The data context.
- --relativeFolderPath 	The relative output folder path to create the files.
- --useDefaultLayout|-udl 	The default layout should be used for the views.
- --referenceScriptLibraries 	Adds _ValidationScriptsPartial to Edit and Create pages.
- -sqlite 	Flag to specify if DbContext should use SQLite instead of SQL Server.

## Migration database ile scaffoldu bağlar create update database komutlarını data modeliyle bağlar
- dotnet ef migrations add InitialCreate Initialcreate adında migration oluşturur scaffoldu yaptıktan sonra otomatik dbye bağlar
- dotnet ef database update



docker compose build ile kurarsın 
docker compose up ile çalıştırırsın

