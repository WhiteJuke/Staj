## dotnet library

- Solution file dotnet new sln ile oluşturulur amacı bir çok projeyi gruplayıp tutabilir
- dotnet new classlib -o StringLibrary yeni classlib oluştur stringlibraryde demek
- dotnet sln add ...../.....csproj dosyasını göstererek solution a eklersin


## Adding project reference to use other functions in other apps

- dotnet add xapp/xapp.csproj reference yapp/yapp.csproj     ..... xapp will use from yapp this says


## Creating a unit test project

- dotnet new mstest -o StringLibraryTest test başlatılır
- dotnet test ..../....csproj ile test çalıştırılır

## Assertler unit testin onaylama argümanları
- Assert.AreEqual 	Verifies that two values or objects are equal. The assert fails if the values or objects aren't equal.
- Assert.AreSame 	Verifies that two object variables refer to the same object. The assert fails if the variables refer to different objects.
- Assert.IsFalse 	Verifies that a condition is false. The assert fails if the condition is true.
- Assert.IsNotNull 	Verifies that an object isn't null. The assert fails if the object is null.