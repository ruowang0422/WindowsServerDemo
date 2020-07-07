# WindowsServerDemo
C# windows服务制作（包括安装及卸载）

安装程序
下面添加一个安装程序，用于安装服务。

1、在service1页面空白处右键-添加安装程序。

2、设置相应的属性，给serviceInstaller1设置属性，主要是描述信息。

3、给serviceProcessInstaller1设置，主要是account。一般选localsystem。

这样服务已经写好了。


服务安装
InstallUtil.exe的使用

找到InstallUtil.exe的文件路径如：C:\Windows\Microsoft.NET\Framework64\v4.0.30319

cmd以管理员身份打开
1、安装一个Windows服务的命令：
InstallUtil.exe   E:\PGSApp\PGS.DeadQRecover.Service.Installer\PGS.DeadQRecover.Service.exe

2、卸载一个Windows服务的命令：
InstallUtil.exe  -u  E:\PGSApp\PGS.DeadQRecover.Service.Installer\PGS.DeadQRecover.Service.exe
