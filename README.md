# Publicar próprio código fonte

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

# Publicar dll de terceiros 

Para que uma `dll` de terceiros seja vinculada (diferente de referenciada) a um pacote nuget, é necessrio adicionar o arquivo `nuspec`:

```
<?xml version="1.0" encoding="utf-8"?>
<package >
  <metadata>
    <id>MyPackageName</id>
    <version>1.0.0</version>
    <authors>author</authors>      
    <requireLicenseAcceptance>false</requireLicenseAcceptance>
    <license type="expression">MIT</license>
    <description>description for my package</description>
    <copyright>Copyright 2021</copyright>
    <dependencies>
      <group targetFramework=".NETStandard2.0">
        <dependency id="SampleDependency" version="1.0.0" />
      </group>
    </dependencies>
  </metadata>
  <files>
    <file src="./libs/libX.dll" target="lib/netstandard2.0" />
  </files>
</package>
```

O arquivo a cima gera um pacote .nupkg com o nome `MyPackageName.1.0.0.nupkg`. Quando referenciado/restaurado ele descompactará também a dll `libX.dll` que foi vinculada a este projeto. Conforme o código acima essa `libX.dll` estaria dentro de uma pasta chamada `libs`.

Lembrando que no seu `Projeto.csproj` é necessário adicionar:

```
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <TargetFramework>netstandard2.0</TargetFramework>   
    <CopyLocalLockFileAssemblies>true</CopyLocalLockFileAssemblies>
  </PropertyGroup>

  <ItemGroup>
    <Reference Include="libX">
      <HintPath>./libs/libX.dll</HintPath>
      <CopyToOutputDirectory>Always</CopyToOutputDirectory>
    </Reference>
  </ItemGroup>

</Project>
```

#### Rodar o pacote:
Imaginemos que o nome do nosso arquivo `.nuspec` seja `Projeto.nuspec`. O comando para gerar o pacote seria:
``` 
dotnet pack -p:NuspecFile=Projeto.nuspec
```

<br>


## As vezes o cache do NuGet buga, então executar o seguinte comando para limpar o cache:
```
dotnet nuget locals --clear all
```

Outra forma de limpar o cache (Linux Ubuntu):
```
ls ~/.nuget/packages/
ls ~/.nuget/packages/ | grep dotnet
sudo rm -r ~/.nuget/packages/<package-name>
```



