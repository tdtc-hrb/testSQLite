# Test SQLite v1.0.112
vs 2008 sp1(.net framework 3.5)


#### [CLR version](http://csharp.tips/tip/article/981-CLR-version-vs--NET-version)
Here is the summary of CLR 4.0 and .NET 4.x version mapping.

|NET Version|CLR Version|
|-|-|
|.NET 4.0|4.0.30319.0 to 4.0.30319.17000|
|.NET 4.5|4.0.30319.17001 to 4.0.3019.18400|
|.NET 4.5.1|4.0.30319.18401 to 4.0.30319.34000|
|.NET 4.5.2|4.0.30319.34001 to 4.0.30319.41999|
|.NET 4.6+|From 4.0.30319.42000|

#### [The Environment class](https://docs.microsoft.com/en-us/dotnet/framework/migration-guide/how-to-determine-which-versions-are-installed#find-clr-versions)
 For .NET Framework versions 4, 4.5, 4.5.1, and 4.5.2, the string representation of the returned Version object has the form 4.0.30319.xxxxx,    
  where xxxxx is less than 42000. For .NET Framework 4.6 and later versions, it has the form 4.0.30319.42000.
```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Diagnostics.Debug.WriteLine(System.Environment.Version);
        }
    }
}
```

#### [Dotnet framework Eol](https://docs.microsoft.com/en-us/lifecycle/products/microsoft-net-framework)

|Version |Start Date |End Date|
|-|-|-|
|[.NET Framework 4.8.1](https://dotnet.microsoft.com/en-us/download/dotnet-framework/thank-you/net481-offline-installer) |Aug 9, 2022  |~|
|[.NET Framework 4.7.2](https://dotnet.microsoft.com/en-us/download/dotnet-framework/thank-you/net472-offline-installer) |Apr 30, 2018 |~|
|[.NET Framework 4.6.2](https://dotnet.microsoft.com/en-us/download/dotnet-framework/thank-you/net462-offline-installer) |Aug 2, 2016  |~|
|[.NET Framework 3.5 Service Pack 1](https://dotnet.microsoft.com/en-us/download/dotnet-framework/thank-you/net35-sp1-web-installer) |Nov 19, 2007 |Jan 9, 2029|
