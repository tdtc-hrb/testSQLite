# Test SQLite v1.0.112
vs 2008 sp1(.net framework 3.5)


#### CLR version

Here is the summary of CLR 4.0 and .NET 4.x version mapping.

|NET Version|CLR Version|
|-|-|
|.NET 4.0|4.0.30319.0 to 4.0.30319.17000|
|.NET 4.5|4.0.30319.17001 to 4.0.3019.18400|
|.NET 4.5.1|4.0.30319.18401 to 4.0.30319.34000|
|.NET 4.5.2|4.0.30319.34001 to 4.0.30319.41999|
|.NET 4.6+|From 4.0.30319.42000|

#### The Environment class
> For .NET Framework versions 4, 4.5, 4.5.1, and 4.5.2, the string representation of the returned Version object has the form 4.0.30319.xxxxx, 
>> where xxxxx is less than 42000. For .NET Framework 4.6 and later versions, it has the form 4.0.30319.42000.

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

#### Dotnet framework Eol

|Version |Start Date |End Date|
|-|-|-|
|.NET Framework 4.8 |Apr 18, 2019 |~|
|.NET Framework 4.7.2 |Apr 30, 2018 |~|
|.NET Framework 4.7.1 |Oct 17, 2017 |~|
|.NET Framework 4.7 |Apr 11, 2017 |~|
|.NET Framework 4.6.2 |Aug 2, 2016 |~|
|.NET Framework 4.6.1 |Nov 30, 2015 |Apr 26, 2022|
|.NET Framework 4.6 |Jul 29, 2015 |Apr 26, 2022|
|.NET Framework 4.5.2 |May 5, 2014 |Apr 26, 2022|
|.NET Framework 4.5.1 |Jan 15, 2014 |Jan 12, 2016|
|.NET Framework 4.5 |Oct 9, 2012 |Jan 12, 2016|
|.NET Framework 4.0 |Apr 12, 2010 |Jan 12, 2016|
|.NET Framework 3.5 Service Pack 1 |Nov 19, 2007 |Jan 9, 2029|
|.NET Framework 3.0 |Nov 21, 2006 |Jul 12, 2011|
|.NET Framework 2.0 |Feb 17, 2006 |Jul 12, 2011|


#### Ref

1.  [CLR version vs .NET version](http://csharp.tips/tip/article/981-CLR-version-vs--NET-version)
2.  [Find CLR versions](https://docs.microsoft.com/en-us/dotnet/framework/migration-guide/how-to-determine-which-versions-are-installed#find-clr-versions)
3.  [Microsoft .NET Framework follows the Component Lifecycle Policy](https://docs.microsoft.com/en-us/lifecycle/products/microsoft-net-framework)
