﻿#pragma checksum "C:\Users\Simona\Desktop\2ndo Carrera\2ºCuatri\DSI\XAML PROYECTO FINAL\Proyecto-Grupo02-DSI\ProyectoGrupo02\InGame.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "86527B6563AA270B2585AD86D52C41707D739C183DA8283D2206982E34B42676"
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
    partial class InGame : 
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
            case 2: // InGame.xaml line 19
                {
                    this.Grid1 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3: // InGame.xaml line 41
                {
                    this.Grid2 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4: // InGame.xaml line 65
                {
                    this.Grid3 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 5: // InGame.xaml line 88
                {
                    this.Pause = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Pause).Click += this.Click_Pause;
                }
                break;
            case 6: // InGame.xaml line 95
                {
                    this.Money = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7: // InGame.xaml line 98
                {
                    global::Windows.UI.Xaml.Controls.Button element7 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element7).Click += this.Coin_Clicker;
                }
                break;
            case 8: // InGame.xaml line 111
                {
                    this.CanvasTop = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 9: // InGame.xaml line 160
                {
                    this.CanvasLeft = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 10: // InGame.xaml line 205
                {
                    this.CanvasRight = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 11: // InGame.xaml line 255
                {
                    this.Papelera = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.Papelera).Drop += this.Papelera_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.Papelera).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 12: // InGame.xaml line 263
                {
                    this.Pot1 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 13: // InGame.xaml line 284
                {
                    global::Windows.UI.Xaml.Controls.Button element13 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element13).Click += this.add_Click;
                }
                break;
            case 17: // InGame.xaml line 271
                {
                    global::Windows.UI.Xaml.Controls.Button element17 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element17).Click += this.Lab_Click;
                }
                break;
            case 21: // InGame.xaml line 206
                {
                    this.RightBackground = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 22: // InGame.xaml line 222
                {
                    this.RightUp0 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp0).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp0).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp0).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 23: // InGame.xaml line 225
                {
                    this.RightUp1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp1).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp1).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp1).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 24: // InGame.xaml line 228
                {
                    this.RightUp2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp2).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp2).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp2).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 25: // InGame.xaml line 231
                {
                    this.RightUp3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp3).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp3).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp3).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 26: // InGame.xaml line 235
                {
                    this.RightDown0 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown0).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown0).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown0).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 27: // InGame.xaml line 238
                {
                    this.RightDown1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown1).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown1).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown1).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 28: // InGame.xaml line 241
                {
                    this.RightDown2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown2).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown2).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown2).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 29: // InGame.xaml line 244
                {
                    this.RightDown3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown3).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown3).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown3).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 30: // InGame.xaml line 161
                {
                    this.LeftBackground = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 31: // InGame.xaml line 176
                {
                    this.leftUp0 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp0).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp0).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp0).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 32: // InGame.xaml line 179
                {
                    this.leftUp1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp1).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp1).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp1).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 33: // InGame.xaml line 182
                {
                    this.leftUp2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp2).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp2).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp2).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 34: // InGame.xaml line 185
                {
                    this.leftUp3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp3).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp3).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp3).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 35: // InGame.xaml line 189
                {
                    this.leftDown0 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftDown0).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftDown0).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 36: // InGame.xaml line 192
                {
                    this.leftDown1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftDown1).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftDown1).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 37: // InGame.xaml line 195
                {
                    this.leftDown2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftDown2).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftDown2).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 38: // InGame.xaml line 198
                {
                    this.leftDown3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftDown3).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftDown3).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 39: // InGame.xaml line 112
                {
                    this.MiddleBackground = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 40: // InGame.xaml line 114
                {
                    global::Windows.UI.Xaml.Controls.Grid element40 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)element40).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 41: // InGame.xaml line 155
                {
                    this.Prueba = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.Prueba).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.Prueba).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 42: // InGame.xaml line 126
                {
                    this.middleLeft0 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft0).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft0).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft0).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 43: // InGame.xaml line 130
                {
                    this.middleLeft1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft1).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft1).DragStarting += this.RightUp0_DragStarting;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft1).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 44: // InGame.xaml line 133
                {
                    this.middleLeft2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft2).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft2).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft2).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 45: // InGame.xaml line 136
                {
                    this.middleLeft3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft3).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft3).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft3).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 46: // InGame.xaml line 140
                {
                    this.middleRight0 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight0).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight0).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight0).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 47: // InGame.xaml line 143
                {
                    this.middleRight1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight1).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight1).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight1).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 48: // InGame.xaml line 146
                {
                    this.middleRight2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight2).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight2).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight2).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 49: // InGame.xaml line 149
                {
                    this.middleRight3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight3).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight3).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight3).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 52: // InGame.xaml line 78
                {
                    this.O6 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.O6).DragStarting += this.a_DragStarting;
                }
                break;
            case 53: // InGame.xaml line 74
                {
                    this.O5 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 54: // InGame.xaml line 59
                {
                    this.O4 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 55: // InGame.xaml line 55
                {
                    this.O3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 56: // InGame.xaml line 51
                {
                    this.O2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 57: // InGame.xaml line 35
                {
                    this.O1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 58: // InGame.xaml line 27
                {
                    this.O0 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.O0).DragStarting += this.a_DragStarting;
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

