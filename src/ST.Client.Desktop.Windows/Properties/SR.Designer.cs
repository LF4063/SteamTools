﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace System.Application.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class SR {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SR() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("System.Application.Properties.SR", typeof(SR).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 @echo off
        ///color a
        ///
        ///goto steam
        ///
        ///:steam
        ///echo 正在检测Steam是否开启......
        ///tasklist | find /I &quot;Steam.exe&quot;
        ///if errorlevel 1 goto steamchina
        ///if not errorlevel 1 goto start
        ///
        ///:steamchina
        ///echo 正在检测国服启动器是否开启......
        ///tasklist | find /I &quot;steamchina.exe&quot;
        ///if errorlevel 1 goto stop
        ///if not errorlevel 1 goto start
        ///
        ///:stop
        ///echo Steam和国服启动器均未开启
        ///goto start
        ///
        ///:killsteam
        ///echo Steam已开启
        ///echo 正在强制关闭
        ///taskkill /F /IM Steam.exe
        ///echo 已强制关闭
        ///goto start
        ///
        ///:killsteamchina
        ///echo Steam已开启
        ///echo 正在强制关闭
        ///taskkill /F /IM steamchin [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        internal static string VacFixCmd {
            get {
                return ResourceManager.GetString("VacFixCmd", resourceCulture);
            }
        }
    }
}
