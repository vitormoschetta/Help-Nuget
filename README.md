# Help-Nuget-Publish

Publicar seus próprios pacotes no <https://www.nuget.org/>

<br>

Passos:

#### 01 - Crie um projeto tipo _classlib_
``` 
dotnet new classlib
``` 

<br>

#### 02 - Desenvolva as funcionalidades do seu projeto

<br>

#### 03 - Modifique o arquivo _.csproj_
``` 
<PropertyGroup>
    <TargetFramework>net5.0</TargetFramework>
    <PackageId>Vithor.StringManipulation</PackageId>
    <Version>1.0.0</Version>
    <Authors>author_name</Authors>
    <Company>company_name</Company>
    <PackageLicenseExpression>MIT</PackageLicenseExpression>
</PropertyGroup>  
``` 

<br>

#### 04 - Gere o arquivo _.nupkg_
Execute o seguinte comando:
``` 
dotnet pack
```

Será gerado um arquivo .nupkg no diretório _bin/Debug/ 

Este arquivo contém o nome definido no .csproj <PackageId>

<br>

#### 05 Acesse <https://www.nuget.org/>
Crie uma conta se não tiver.  
Crie uma API Key
Vá para "Manage Packages" e clique em "Add New". 

Aqui você poderá fazer upload do arquivo .nupkg gerado.



<br>

#### Observações  
Cada biblioteca de classe deve conter seu próprio `.nuget` publicado.   
Supondo que criamos dois projetos `classlib` A e B. O projeto A está referenciando o B. Quando publicar o projeto A no nuget ele conterá uma dependência do projeto B, que também deve estar no nuget. 











