﻿#pragma checksum "C:\Users\Simona\Desktop\2ndo Carrera\2ºCuatri\DSI\XAML PROYECTO FINAL\Proyecto-Grupo02-DSI\ProyectoGrupo02\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "878F08FE1F9CDFA4BA93FAD52F337725A54D6C0163717400B448F64D53B42E4A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoGrupo02
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 15
                {
                    this.bats1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 3: // MainPage.xaml line 18
                {
                    this.bats2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 4: // MainPage.xaml line 26
                {
                    this.Play = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Play).Click += this.Play_Click;
                }
                break;
            case 5: // MainPage.xaml line 32
                {
                    this.Settings = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Settings).Click += this.Settings_OnClick;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

