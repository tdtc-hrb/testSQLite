# Test SQLite
  附带密码功能的SQLite最后版本: v1.0.112

简介：    
  本示例使用SQLite的密码、外键功能。以及关闭临时文件（journal mode=Off）。    
  通过查询和插入（修改、删除）来演示C#使用SQLite的实用性。


# 工程设置
  使用VS2017、VS2019、VS2022新建工程， 需要设置Target framework: (4.0~4.6)
```
Project -> Properties
```
Application -> Target framework

![dotnet version - target](https://github.com/tdtc-hrb/cnblogs/raw/master/images/targetversion.png)

> Windows XP 只能支持到.net 4.0.3.

## 引用
- [For Vs 2008](http://system.data.sqlite.org/blobs/1.0.112.0/sqlite-netFx35-setup-bundle-x86-2008-1.0.112.0.exe)
- [For Vs 2010](http://system.data.sqlite.org/blobs/1.0.112.0/sqlite-netFx40-setup-bundle-x86-2010-1.0.112.0.exe)
- [For Vs 2012](http://system.data.sqlite.org/blobs/1.0.112.0/sqlite-netFx45-setup-bundle-x86-2012-1.0.112.0.exe)
- [For Vs 2013](http://system.data.sqlite.org/blobs/1.0.112.0/sqlite-netFx451-setup-bundle-x86-2013-1.0.112.0.exe)
- [For Vs 2015](http://system.data.sqlite.org/blobs/1.0.112.0/sqlite-netFx46-setup-bundle-x86-2015-1.0.112.0.exe)

### vs17/19/22
Project -> Add Reference
Browse: 选择Sqlite file
![manual add GAC](https://github.com/tdtc-hrb/cnblogs/raw/master/images/manaddgac.png)

### vs08/10/12/13/15
References -> Add Reference

![vs2012 ui](https://github.com/tdtc-hrb/cnblogs/raw/master/images/20200402114539433.png)


选择“System.Data.SQLite Core”
![vs2012 ui](https://github.com/tdtc-hrb/cnblogs/raw/master/images/20200402114730227.png)


# Deploy
解压文件，拷贝System.Data.SQLite.dll到可执行文件目录.
- [Precompiled Binaries - 2008](https://system.data.sqlite.org/blobs/1.0.112.0/sqlite-netFx35-binary-bundle-Win32-2008-1.0.112.0.zip)
- [Precompiled Binaries - 2010](https://system.data.sqlite.org/blobs/1.0.112.0/sqlite-netFx40-binary-bundle-Win32-2010-1.0.112.0.zip)
- [Precompiled Binaries - 2012](https://system.data.sqlite.org/blobs/1.0.112.0/sqlite-netFx45-binary-bundle-Win32-2012-1.0.112.0.zip)
- [Precompiled Binaries - 2013](https://system.data.sqlite.org/blobs/1.0.112.0/sqlite-netFx451-binary-bundle-Win32-2013-1.0.112.0.zip)
- [Precompiled Binaries - 2015](https://system.data.sqlite.org/blobs/1.0.112.0/sqlite-netFx46-binary-bundle-Win32-2015-1.0.112.0.zip)

## [Runtime](https://docs.microsoft.com/en-US/cpp/windows/latest-supported-vc-redist)
- Visual C++ 2008 SP1    
[x64](https://download.microsoft.com/download/5/D/8/5D8C65CB-C849-4025-8E95-C3966CAFD8AE/vcredist_x64.exe)    
[x86](https://download.microsoft.com/download/5/D/8/5D8C65CB-C849-4025-8E95-C3966CAFD8AE/vcredist_x86.exe)
- Visual C++ 2010 SP1    
[x64](https://download.microsoft.com/download/1/6/5/165255E7-1014-4D0A-B094-B6A430A6BFFC/vcredist_x64.exe)    
[x86](https://download.microsoft.com/download/1/6/5/165255E7-1014-4D0A-B094-B6A430A6BFFC/vcredist_x86.exe)
- Visual C++ 2012 Update 4    
[x64](https://download.microsoft.com/download/1/6/B/16B06F60-3B20-4FF2-B699-5E9B7962F9AE/VSU_4/vcredist_x64.exe)    
[x86](https://download.microsoft.com/download/1/6/B/16B06F60-3B20-4FF2-B699-5E9B7962F9AE/VSU_4/vcredist_x86.exe)
- Visual C++ 2013 Update 2    
[x64](https://aka.ms/highdpimfc2013x64enu)    
[x86](https://aka.ms/highdpimfc2013x86enu)
- [Visual C++ 2015 Update 3](https://www.microsoft.com/en-us/download/details.aspx?id=53587)

## 操作步骤
1. 新建tdtc_scale.db    
2. 点击+password    
3. 点击Gen Table    
4. 输入insert语句，并点击exec    
5. 输入select语句，并点击search

完整的窗体
![program ui](https://github.com/tdtc-hrb/cnblogs/raw/master/images/20200327103150877.png)


# 参考文档
- [SQLite.NET.chm](http://system.data.sqlite.org/index.html/finfo?name=Doc/SQLite.NET.chm)
- [Install the .NET Framework on Windows XP and Windows Server 2003](https://docs.microsoft.com/zh-cn/previous-versions/dotnet/framework/install/on-windows-xp#:~:text=%E5%8F%AF%E4%BB%A5%E5%9C%A8%20Windows%20XP%20%E4%B8%8A%E5%AE%89%E8%A3%85%20.NET%20Framework%203.5%20%E3%80%82.,applications%20built%20for%20.NET%20Framework%201.0%20through%203.5.)
