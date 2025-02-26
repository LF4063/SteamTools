### 版本亮点
1. 新增 Android x86 架构包，适用于 Intel、AMD 芯片的设备或虚拟机
2. ASF 升级至 **V5.2.0.10**
3. 新增 ASF 控制台字体大小、最大行数设置项
4. 新增 Steam 下载完成定时关机、睡眠功能
5. 新增 代理设置可自定义 DNS
6. 新增 ASF 编辑/移除 Bot 功能
7. 新增 Android ASF 本地挂卡功能 (Beta)
8. 新增 Microsoft/Xbox 相关加速服务 (需要升级到 **2.6.3** 之后可用)
9. 新增 Uplay 相关加速服务 (需要升级到 **2.6.3** 之后可用)
10. 新增 OneDrive 等更多相关加速服务 (需要升级到 **2.6.3** 之后可用)
11. 优化 Desktop 加速代理性能
12. 优化 Desktop 脚本注入打包的性能
13. 优化 Desktop 已安装游戏加载性能
14. 从此版本开始将使用 Github Action 自动化部署发布

### 修复问题
1. 改进 Desktop 网络加速现默认使用阿里 DNS(223.5.5.5, 223.6.6.6)
2. 改进 自动更新包文件校验失败时提示
3. 改进 自动更新失败时将自动跳转官网
4. 改进 ASF IPC 默认端口号由 1242 改为 6242
5. 修复 Linux 与 macOS 中 ASF-UI 解压包文件夹分隔符不正确
6. 修复 Windows Hosts 只读时尝试取消只读属性的操作没有正确执行
7. 修复 Windows 此软件自动更新删除更新包缓存时因文件占用引发的中断
8. 修复 Desktop 高 DPI 下动态桌面错位
9. 改进 Android UI
10. 改进 Android 冷启动速度
11. 改进 Android 导入令牌成功后回到列表页
12. 修复 Android 屏幕捕获设置项不生效
13. 修复 Android 令牌列表有时不显示值
14. 修复 本地令牌确认交易在登录时可能会卡住
15. 修复 Windows 启用动态桌面后全屏可能导致窗口冻结无法操作
16. 修复 Windows 动态背景有时会被其他窗口遮挡
17. 改进 本地令牌 登录验证码无法加载时可点击在浏览器中查看验证码图片
18. 修复 Desktop 加速代理中可能出现的一些错误
19. 改进 Desktop 令牌详情 UI
20. 改进 Desktop 账号切换中的用户名信息现在默认隐藏
21. 修复 Android 确认交易 全选/全不选 复选框勾选时逻辑不正确执行
22. 改进 Desktop 深色模式与浅色模式的视觉效果
23. 修复 Pixiv 加速不能登录的问题
24. 修复 Twitch 加速不计算掉宝进度的问题
25. 修复 Discord 加速检测更新失败导致无法启动客户端的问题
26. 修复 Windows 因添加 JumpList 时可能导致的闪退 
27. 修复 Desktop 本地令牌 点击锁定后输入密码按回车解锁会循环无限触发锁定的问题


### 已知问题
- 除 Windows 之外的平台此软件自动更新尚不可用
- Desktop 
	- macOS
		- [尚未公证](https://support.apple.com/zh-cn/guide/mac-help/mh40616/10.15/mac/10.15)，这会影响 macOS Catalina（版本 10.15）以上版本
	- Linux
		- **Hosts 代理模式**可能无法配置成功，推荐使用**系统代理模式**
		- 系统代理模式下discord更新下载加速有问题暂不可用
		- 窗口弹出位置不正确
		- 鼠标指针浮动样式不正确
	- Windows
		- Windows 11 
			- 在 CPU 不受支持的 Win11 上无法启动，Windows 日志中显示 ```Failed to create CoreCLR, HRESULT: 0x80004005```
			- 仅 .NET 6.0 受此影响，在几周后的 Insider 中会修复，见 [issue](https://github.com/dotnet/core/issues/6733)
			- **解决方案：** 可尝试使用旧版本 例如 v2.3.0
		- Windows 7
			- 先决条件
				- 需要安装 Extended Security Update
			- 在不符合先决条件的情况下运行可能导致
				- 程序无法正常运行
				- 运行程序时提示 计算机中丢失 api-ms-win-core-winrt-l1-1-0.dll
			- **解决方案**
				- 因 [Windows 7 延长结束日期](https://support.microsoft.com/zh-cn/windows/windows-7-%E6%94%AF%E6%8C%81%E4%BA%8E-2020-%E5%B9%B4-1-%E6%9C%88-14-%E6%97%A5%E7%BB%88%E6%AD%A2-b75d4580-2cc7-895a-2c9c-1466d9a53962)以于 2020 年 1 月 14 日结束支持
					- 所以必须安装 [Extended Security Update](https://docs.microsoft.com/zh-cn/troubleshoot/windows-client/windows-7-eos-faq/windows-7-extended-security-updates-faq) 支持，在安装第三年的补丁后[结束支持日期](https://docs.microsoft.com/zh-cn/lifecycle/products/windows-7)可延长至 2023 年 1 月 10 日
					- 可安装 *第三方* 补丁整合包例如 **[UpdatePack7R2](https://cn.bing.com/search?q=UpdatePack7R2)** *或* 购买官方 ESU 产品密钥 解决
				- 下载 api-ms-win-core-winrt-l1-1-0.dll 文件放入程序根目录(Steam++.exe 所在文件夹)
					- [从 Github 上直接下载](https://github.com/BeyondDimension/SteamTools/raw/develop/references/runtime.win7-x64.Microsoft.NETCore.Windows.ApiSets/api-ms-win-core-winrt-l1-1-0.dll)
					- [从 Gitee 上直接下载](https://gitee.com/rmbgame/SteamTools/raw/develop/references/runtime.win7-x64.Microsoft.NETCore.Windows.ApiSets/api-ms-win-core-winrt-l1-1-0.dll)
					- [从 NuGet 上下载后提取](https://www.nuget.org/api/v2/package/runtime.win7-x64.Microsoft.NETCore.Windows.ApiSets/1.0.1)
						- .nupkg 文件可使用解压工具打开或解压，找到此文件复制即可

[![steampp.net](https://img.shields.io/badge/WebSite-steampp.net-brightgreen.svg?style=flat-square&color=61dafb)](https://steampp.net)
[![Steam++ v2.6.3](https://img.shields.io/badge/Steam++-v2.6.3-brightgreen.svg?style=flat-square&color=512bd4)]()
  
  
##### [不知道该下载哪个文件?](./download-guide.md)
---

### 文件校验
|  File  | Checksum (SHA256)  |
|  ----  |  ----  |
| Steam++_win_x64_v2.6.3.7z  | SHA256 |
| Steam++_win_x64_fde_v2.6.3.7z  | SHA256 |
| | |
| Steam++_win_x64_v2.6.3.exe  | SHA256 |
| Steam++_win_x64_fde_v2.6.3.exe  | SHA256 |
| | |
| Steam++_linux_x64_v2.6.3.7z  | SHA256 |
| Steam++_linux_arm64_v2.6.3.7z  | SHA256 |
| | |
| Steam++_linux_x64_v2.6.3.deb  | SHA256 |
| Steam++_linux_arm64_v2.6.3.deb  | SHA256 |
| | |
| Steam++_linux_x64_v2.6.3.rpm  | SHA256 |
| Steam++_linux_arm64_v2.6.3.rpm  | SHA256 |
| | |
| Steam++_macos_x64_v2.6.3.dmg  | SHA256 |
| | |
| Steam++_android_arm64_v8a_v2.6.3.apk  | SHA256 |
| Steam++_android_armeabi_v7a_v2.6.3.apk  | SHA256 |
| Steam++_android_x86_v2.6.3.apk  | SHA256 |
