# Vscode-dotnetTest
[TOC]

### 1、创建项目文件夹及项目解决方案
	NsqDome 、src
	创建项目解决方案NsqDome.sln 
		dotnet new sln -n NsqDome
![](https://www.showdoc.com.cn/server/api/attachment/visitfile/sign/900a3e0e20b9376021d1ba43f0fa5e76)

	查询解决方案项目列表
	dotnet sln list
![](https://www.showdoc.com.cn/server/api/attachment/visitfile/sign/608977911545e6f12ee622fe5cbad319)
### 2、创建项目
##### 2.1、NsqProducer（控制台）
	PS D:\dotnetTest\NsqDome\src> dotnet new console -n NsqProducer
![](https://www.showdoc.com.cn/server/api/attachment/visitfile/sign/cd41ee41b81d05bb032f97a8f15d8afa)

	将控制台项目加入到解决方案中
	D:\dotnetTest\NsqDome> dotnet sln add .\src\NsqProducer\NsqProducer.csproj
##### 2.2创建NsqConsumer控制台
	D:\dotnetTest\NsqDome\src>dotnet new console -n NsqConsumer
![](https://www.showdoc.com.cn/server/api/attachment/visitfile/sign/725280431f98dd3e7441e7f529045141)

	将控制台项目加入到解决方案中
	D:\dotnetTest\NsqDome> dotnet sln add .\src\NsqConsumer\NsqConsumer.csproj
##### 2.3创建公用类库NsqModel
	D:\dotnetTest\NsqDome\src> dotnet new classlib -n NsqModel
![](https://www.showdoc.com.cn/server/api/attachment/visitfile/sign/e0cf5eb5a8d8f7f83effaefa6eaf3fcc)

	将控制台项目加入到解决方案中
	D:\dotnetTest\NsqDome> dotnet sln add .\src\NsqModel\NsqModel.csproj
### 3、添加NuGet 包
	3.1安装NuGet Package Manager插件 
		1、ctrl+shift+p 打开搜索框 输入NuGet 选择add Package
		2、Newtonsoftjson输入需要添加的包：newt回车键选择Newtonsoft.Json
		3、选择版本号
		4、选择给那个项目添加
![](https://www.showdoc.com.cn/server/api/attachment/visitfile/sign/1f104819bb5667c97822a3cf34b304df)
![](https://www.showdoc.com.cn/server/api/attachment/visitfile/sign/e9bfe4c1bebc2f8c7023580772458a0d)
![](https://www.showdoc.com.cn/server/api/attachment/visitfile/sign/e5ff3711cd28cf13b2cab414dc32d5f1)
![](https://www.showdoc.com.cn/server/api/attachment/visitfile/sign/7f970d2693b73830f7f306188628fdbb)
![](https://www.showdoc.com.cn/server/api/attachment/visitfile/sign/5ad5a8b5c7e9b22fd6eeb0ef643c1c78)

	使用vscode安装nuget插件之后出现错误：
		"Versioning information could not be retrieved from the NuGet package repository. Please try again later."
		打开路径下的文件fetchPackageVersions.js
		/Users/用户名/.vscode/extensions/jmrog.vscode-nuget-package-manager-1.1.6/out/src/actions/add-methods/fetchPackageVersions.js
		修改代码
		...node_fetch_1.default(`${versionsUrl}${selectedPackageName}/index.json`, utils_1.getFetchOptions(vscode.workspace.getConfiguration('http')))
		修改后的代码了toLowerCase()方法
		...node_fetch_1.default(`${versionsUrl}${selectedPackageName.toLowerCase()}/index.json`, utils_1.getFetchOptions(vscode.workspace.getConfiguration('http')))
		重启vscode问题解决！

### 4、添加项目引用
	使用dotnet add 需要添加的项目  reference 被引用的项目  
	 D:\dotnetTest\NsqDome\src> dotnet add .\NsqConsumer\NsqConsumer.csproj reference .\NsqModel\NsqModel.csproj
![](https://www.showdoc.com.cn/server/api/attachment/visitfile/sign/f48cdb6d0a1213d4b6f97c9444bfe2c1)
### 5、补全缺失引用及快速添加class类
	补全引用
![](https://www.showdoc.com.cn/server/api/attachment/visitfile/sign/e9b89c1bf340109e7f2d70d8a87f013b)

	快速添加class类：右键项目
	安装插件：C# Extensions
![](https://www.showdoc.com.cn/server/api/attachment/visitfile/sign/3639c04f64654c1ff68b996db7a86044)
### 6、添加多项目调试
![](https://www.showdoc.com.cn/server/api/attachment/visitfile/sign/c7b4b839c8da28465ff07c9d0139b457)

	添加多项目调试
![](https://www.showdoc.com.cn/server/api/attachment/visitfile/sign/42e61c113828c78a752e70470cddd9d4)
### 9、C#常用插件
	Auto-Using for C#
	C# XML Documentation Comments //注解用
	NuGet Package Manager  //添加nuget
	C# Extensions  //快速添加class类
![](https://www.showdoc.com.cn/server/api/attachment/visitfile/sign/17cd18c77688d2bb9b9ceec1e33dd4bf)