﻿#pragma checksum "C:\Users\Simona\Desktop\2ndo Carrera\2ºCuatri\DSI\XAML PROYECTO FINAL\Proyecto-Grupo02-DSI\ProyectoGrupo02\InGame.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A4A89019A22A5608AF02F044F725810802578DD3230262924A22E339BA768FFA"
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
            case 2: // InGame.xaml line 118
                {
                    this.Pause = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Pause).Click += this.Click_Pause;
                }
                break;
            case 3: // InGame.xaml line 125
                {
                    this.Money = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // InGame.xaml line 128
                {
                    global::Windows.UI.Xaml.Controls.Button element4 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element4).Click += this.Coin_Clicker;
                }
                break;
            case 5: // InGame.xaml line 390
                {
                    this.Papelera = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.Papelera).Drop += this.Papelera_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.Papelera).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 6: // InGame.xaml line 399
                {
                    this.Pot1 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 7: // InGame.xaml line 420
                {
                    global::Windows.UI.Xaml.Controls.Button element7 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element7).Click += this.add_Click;
                }
                break;
            case 11: // InGame.xaml line 407
                {
                    global::Windows.UI.Xaml.Controls.Button element11 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element11).Click += this.Lab_Click;
                }
                break;
            case 15: // InGame.xaml line 312
                {
                    this.CanvasRight = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 16: // InGame.xaml line 313
                {
                    this.RightBackground = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 17: // InGame.xaml line 328
                {
                    this.UR0 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.UR0).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.UR0).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.UR0).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 18: // InGame.xaml line 335
                {
                    this.UR1 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.UR1).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.UR1).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.UR1).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 19: // InGame.xaml line 342
                {
                    this.UR2 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.UR2).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.UR2).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.UR2).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 20: // InGame.xaml line 349
                {
                    this.UR3 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.UR3).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.UR3).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.UR3).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 21: // InGame.xaml line 356
                {
                    this.DR0 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.DR0).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.DR0).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.DR0).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 22: // InGame.xaml line 363
                {
                    this.DR1 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.DR1).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.DR1).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 23: // InGame.xaml line 369
                {
                    this.DR2 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.DR2).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.DR2).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 24: // InGame.xaml line 375
                {
                    this.DR3 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.DR3).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.DR3).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 25: // InGame.xaml line 378
                {
                    this.RightDown3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 26: // InGame.xaml line 372
                {
                    this.RightDown2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 27: // InGame.xaml line 366
                {
                    this.RightDown1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 28: // InGame.xaml line 360
                {
                    this.RightDown0 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 29: // InGame.xaml line 353
                {
                    this.RightUp3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 30: // InGame.xaml line 346
                {
                    this.RightUp2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 31: // InGame.xaml line 339
                {
                    this.RightUp1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 32: // InGame.xaml line 332
                {
                    this.RightUp0 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 33: // InGame.xaml line 233
                {
                    this.CanvasLeft = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 34: // InGame.xaml line 234
                {
                    this.LeftBackground = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 35: // InGame.xaml line 249
                {
                    this.UL0 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.UL0).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.UL0).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.UL0).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 36: // InGame.xaml line 256
                {
                    this.UL1 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.UL1).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.UL1).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.UL1).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 37: // InGame.xaml line 263
                {
                    this.UL2 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.UL2).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.UL2).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.UL2).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 38: // InGame.xaml line 270
                {
                    this.UL3 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.UL3).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.UL3).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.UL3).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 39: // InGame.xaml line 277
                {
                    this.DL0 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.DL0).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.DL0).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.DL0).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 40: // InGame.xaml line 284
                {
                    this.DL1 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.DL1).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.DL1).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.DL1).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 41: // InGame.xaml line 291
                {
                    this.DL2 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.DL2).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.DL2).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.DL2).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 42: // InGame.xaml line 298
                {
                    this.DL3 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.DL3).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.DL3).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.DL3).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 43: // InGame.xaml line 302
                {
                    this.leftDown3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftDown3).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftDown3).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 44: // InGame.xaml line 295
                {
                    this.leftDown2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 45: // InGame.xaml line 288
                {
                    this.leftDown1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 46: // InGame.xaml line 281
                {
                    this.leftDown0 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 47: // InGame.xaml line 274
                {
                    this.leftUp3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 48: // InGame.xaml line 267
                {
                    this.leftUp2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 49: // InGame.xaml line 260
                {
                    this.leftUp1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 50: // InGame.xaml line 253
                {
                    this.leftUp0 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 51: // InGame.xaml line 142
                {
                    this.CanvasTop = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 52: // InGame.xaml line 143
                {
                    this.MiddleBackground = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 53: // InGame.xaml line 145
                {
                    global::Windows.UI.Xaml.Controls.Grid element53 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)element53).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 54: // InGame.xaml line 221
                {
                    this.MR3 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.MR3).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.MR3).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.MR3).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 55: // InGame.xaml line 225
                {
                    this.middleRight3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 56: // InGame.xaml line 212
                {
                    this.MR2 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.MR2).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.MR2).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.MR2).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 57: // InGame.xaml line 216
                {
                    this.middleRight2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 58: // InGame.xaml line 203
                {
                    this.MR1 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.MR1).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.MR1).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.MR1).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 59: // InGame.xaml line 207
                {
                    this.middleRight1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 60: // InGame.xaml line 194
                {
                    this.MR0 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.MR0).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.MR0).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.MR0).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 61: // InGame.xaml line 198
                {
                    this.middleRight0 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 62: // InGame.xaml line 185
                {
                    this.ML3 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.ML3).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.ML3).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.ML3).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 63: // InGame.xaml line 189
                {
                    this.middleLeft3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 64: // InGame.xaml line 176
                {
                    this.ML2 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.ML2).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.ML2).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.ML2).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 65: // InGame.xaml line 180
                {
                    this.middleLeft2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 66: // InGame.xaml line 167
                {
                    this.ML1 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.ML1).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.ML1).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.ML1).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 67: // InGame.xaml line 171
                {
                    this.middleLeft1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 68: // InGame.xaml line 158
                {
                    this.ML0 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.ML0).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.ML0).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.ML0).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 69: // InGame.xaml line 162
                {
                    this.middleLeft0 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 72: // InGame.xaml line 88
                {
                    this.Grid3 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 73: // InGame.xaml line 105
                {
                    this.O6 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.O6).DragStarting += this.a_DragStarting;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.O6).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 74: // InGame.xaml line 108
                {
                    this.Ajo = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 75: // InGame.xaml line 97
                {
                    this.O5 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.O5).DragStarting += this.a_DragStarting;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.O5).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 76: // InGame.xaml line 100
                {
                    this.Canyon = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 77: // InGame.xaml line 49
                {
                    this.Grid2 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 78: // InGame.xaml line 77
                {
                    this.O4 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.O4).DragStarting += this.a_DragStarting;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.O4).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 79: // InGame.xaml line 80
                {
                    this.Rice = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 80: // InGame.xaml line 69
                {
                    this.O3 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.O3).DragStarting += this.a_DragStarting;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.O3).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 81: // InGame.xaml line 72
                {
                    this.HolyWater = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 82: // InGame.xaml line 61
                {
                    this.O2 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.O2).DragStarting += this.a_DragStarting;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.O2).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 83: // InGame.xaml line 64
                {
                    this.Guillotine = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 84: // InGame.xaml line 22
                {
                    this.Grid1 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 85: // InGame.xaml line 38
                {
                    this.O1 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.O1).DragStarting += this.a_DragStarting;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.O1).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 86: // InGame.xaml line 41
                {
                    this.Potion = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 87: // InGame.xaml line 30
                {
                    this.O0 = (global::Windows.UI.Xaml.Controls.ContentControl)(target);
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.O0).DragStarting += this.a_DragStarting;
                    ((global::Windows.UI.Xaml.Controls.ContentControl)this.O0).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 88: // InGame.xaml line 33
                {
                    this.Sun = (global::Windows.UI.Xaml.Controls.Image)(target);
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

