# Test SQLite(v1.0.112)
windows XP 只能支持到.net 4.0.3.



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

## 组件
- [For Vs 2010](http://system.data.sqlite.org/blobs/1.0.112.0/sqlite-netFx40-setup-bundle-x86-2010-1.0.112.0.exe)
- [For Vs 2012](http://system.data.sqlite.org/blobs/1.0.112.0/sqlite-netFx45-setup-bundle-x86-2012-1.0.112.0.exe)
- [For Vs 2013](http://system.data.sqlite.org/blobs/1.0.112.0/sqlite-netFx451-setup-bundle-x86-2013-1.0.112.0.exe)
- [For Vs 2015](http://system.data.sqlite.org/blobs/1.0.112.0/sqlite-netFx46-setup-bundle-x86-2015-1.0.112.0.exe)

- [Precompiled Binaries - 2010](https://system.data.sqlite.org/blobs/1.0.112.0/sqlite-netFx40-binary-bundle-Win32-2010-1.0.112.0.zip)
- [Precompiled Binaries - 2012](https://system.data.sqlite.org/blobs/1.0.112.0/sqlite-netFx45-binary-bundle-Win32-2012-1.0.112.0.zip)
- [Precompiled Binaries - 2013](https://system.data.sqlite.org/blobs/1.0.112.0/sqlite-netFx451-binary-bundle-Win32-2013-1.0.112.0.zip)
- [Precompiled Binaries - 2015](https://system.data.sqlite.org/blobs/1.0.112.0/sqlite-netFx46-binary-bundle-Win32-2015-1.0.112.0.zip)


## 引用

### SQLite file
> System.Data.SQLite.dll

- .net 4.0
```
C:\Program Files (x86)\System.Data.SQLite\2010\GAC
```
- .net 4.5
```
C:\Program Files (x86)\System.Data.SQLite\2012\GAC
```
- .net 4.5.1
```
C:\Program Files (x86)\System.Data.SQLite\2013\GAC
```
- .net 4.6
```
C:\Program Files (x86)\System.Data.SQLite\2015\GAC
```

### vs17/19/22 
Project -> Add Reference
Browse: 选择Sqlite file

### vs08/10/12/13/15
References -> Add Reference

![vs2012 ui](https://github.com/tdtc-hrb/cnblogs/raw/master/images/20200402114539433.png)



选择“System.Data.SQLite Core”
![vs2012 ui](https://github.com/tdtc-hrb/cnblogs/raw/master/images/20200402114730227.png)


## 完整的窗体
![program ui](https://github.com/tdtc-hrb/cnblogs/raw/master/images/20200327103150877.png)

# Deploy
1. 新建tdtc_scale.db    
2. 点击+password    
3. 点击Gen Table    
4. 输入insert语句，并点击exec    
5. 输入select语句，并点击search    


# 参考文档
- [SQLite.NET.chm](http://system.data.sqlite.org/index.html/finfo?name=Doc/SQLite.NET.chm)
- [Install the .NET Framework on Windows XP and Windows Server 2003](https://docs.microsoft.com/zh-cn/previous-versions/dotnet/framework/install/on-windows-xp#:~:text=%E5%8F%AF%E4%BB%A5%E5%9C%A8%20Windows%20XP%20%E4%B8%8A%E5%AE%89%E8%A3%85%20.NET%20Framework%203.5%20%E3%80%82.,applications%20built%20for%20.NET%20Framework%201.0%20through%203.5.)
