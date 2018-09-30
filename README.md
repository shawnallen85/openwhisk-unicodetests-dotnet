# Unicode Tests for the OpenWhisk dotnet:2.1 runtime

## Compiling
```
dotnet restore
dotnet publish -c Release -o ..\out
```

## Publishing
```
cd out
zip dotnet-2.1.bin .
wsk action create UnicodeTestDN dotnet-2.1.bin --kind dotnet:2.1 --main Apache.OpenWhisk.UnicodeTests.Dotnet::Apache.OpenWhisk.UnicodeTests.Dotnet.Unicode::Main
```
