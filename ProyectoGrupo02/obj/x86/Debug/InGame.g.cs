﻿#pragma checksum "C:\Users\ADRIAN\Desktop\2.Carrera\2ºCUATRI\Proyecto-Grupo02-DSI\ProyectoGrupo02\InGame.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "32ADC2071CE0F76AFE4CAC0CBB56DE1F2382B4D0A8E2B8DB70FB73FA843353C7"
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_Image_Source(global::Windows.UI.Xaml.Controls.Image obj, global::Windows.UI.Xaml.Media.ImageSource value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), targetNullValue);
                }
                obj.Source = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class InGame_obj51_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IInGame_Bindings
        {
            private global::ProyectoGrupo02.VMObject dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::System.WeakReference obj51;
            private global::Windows.UI.Xaml.Controls.Image obj52;
            private global::Windows.UI.Xaml.Controls.TextBlock obj53;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj52SourceDisabled = false;
            private static bool isobj53TextDisabled = false;

            private InGame_obj51_BindingsTracking bindingsTracking;

            public InGame_obj51_Bindings()
            {
                this.bindingsTracking = new InGame_obj51_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 83 && columnNumber == 36)
                {
                    isobj52SourceDisabled = true;
                }
                else if (lineNumber == 84 && columnNumber == 40)
                {
                    isobj53TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 51: // InGame.xaml line 81
                        this.obj51 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.StackPanel)target);
                        break;
                    case 52: // InGame.xaml line 83
                        this.obj52 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 53: // InGame.xaml line 84
                        this.obj53 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 if (this.SetDataRoot(args.NewValue))
                 {
                    this.Update();
                 }
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
                Recycle();
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
                switch(phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(item);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            (this.obj51.Target as global::Windows.UI.Xaml.Controls.StackPanel).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::ProyectoGrupo02.VMObject) item, 1 << phase);
            }

            public void Recycle()
            {
                this.bindingsTracking.ReleaseAllListeners();
            }

            // IInGame_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::ProyectoGrupo02.VMObject)newDataRoot;
                    return true;
                }
                return false;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::ProyectoGrupo02.VMObject obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_o(obj.o, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_Precio(obj.Precio, phase);
                    }
                }
            }
            private void Update_o(global::ProyectoGrupo02.Object obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_o_Imagen(obj.Imagen, phase);
                    }
                }
            }
            private void Update_o_Imagen(global::System.String obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // InGame.xaml line 83
                    if (!isobj52SourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj52, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                    }
                }
            }
            private void Update_Precio(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // InGame.xaml line 84
                    if (!isobj53TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj53, obj.ToString(), null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class InGame_obj51_BindingsTracking
            {
                private global::System.WeakReference<InGame_obj51_Bindings> weakRefToBindingObj; 

                public InGame_obj51_BindingsTracking(InGame_obj51_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<InGame_obj51_Bindings>(obj);
                }

                public InGame_obj51_Bindings TryGetBindingObject()
                {
                    InGame_obj51_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                }

            }
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class InGame_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IInGame_Bindings
        {
            private global::ProyectoGrupo02.InGame dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj3;
            private global::Windows.UI.Xaml.Controls.GridView obj49;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj3TextDisabled = false;
            private static bool isobj49ItemsSourceDisabled = false;

            private InGame_obj1_BindingsTracking bindingsTracking;

            public InGame_obj1_Bindings()
            {
                this.bindingsTracking = new InGame_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 130 && columnNumber == 35)
                {
                    isobj3TextDisabled = true;
                }
                else if (lineNumber == 78 && columnNumber == 55)
                {
                    isobj49ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3: // InGame.xaml line 130
                        this.obj3 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 49: // InGame.xaml line 76
                        this.obj49 = (global::Windows.UI.Xaml.Controls.GridView)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IInGame_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::ProyectoGrupo02.InGame)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::ProyectoGrupo02.InGame obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Objects(obj.Objects, phase);
                    }
                }
                this.Update_ProyectoGrupo02_App_monedas(global::ProyectoGrupo02.App.monedas, phase);
            }
            private void Update_ProyectoGrupo02_App_monedas(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // InGame.xaml line 130
                    if (!isobj3TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj3, obj.ToString(), null);
                    }
                }
            }
            private void Update_Objects(global::System.Collections.ObjectModel.ObservableCollection<global::ProyectoGrupo02.VMObject> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // InGame.xaml line 76
                    if (!isobj49ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj49, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class InGame_obj1_BindingsTracking
            {
                private global::System.WeakReference<InGame_obj1_Bindings> weakRefToBindingObj; 

                public InGame_obj1_BindingsTracking(InGame_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<InGame_obj1_Bindings>(obj);
                }

                public InGame_obj1_Bindings TryGetBindingObject()
                {
                    InGame_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                }

            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // InGame.xaml line 123
                {
                    this.Pause = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Pause).Click += this.Click_Pause;
                }
                break;
            case 3: // InGame.xaml line 130
                {
                    this.Money = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4: // InGame.xaml line 133
                {
                    global::Windows.UI.Xaml.Controls.Button element4 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element4).Click += this.Coin_Clicker;
                }
                break;
            case 5: // InGame.xaml line 297
                {
                    this.Papelera = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.Papelera).Drop += this.Papelera_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.Papelera).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 6: // InGame.xaml line 305
                {
                    this.Pot1 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 7: // InGame.xaml line 328
                {
                    global::Windows.UI.Xaml.Controls.Button element7 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element7).Click += this.add_Click;
                }
                break;
            case 11: // InGame.xaml line 313
                {
                    global::Windows.UI.Xaml.Controls.Button element11 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element11).Click += this.Lab_Click;
                }
                break;
            case 15: // InGame.xaml line 245
                {
                    this.CanvasRight = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 16: // InGame.xaml line 246
                {
                    this.RightBackground = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 17: // InGame.xaml line 262
                {
                    this.RightUp0 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp0).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp0).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp0).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 18: // InGame.xaml line 265
                {
                    this.RightUp1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp1).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp1).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp1).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 19: // InGame.xaml line 268
                {
                    this.RightUp2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp2).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp2).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp2).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 20: // InGame.xaml line 271
                {
                    this.RightUp3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp3).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp3).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp3).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 21: // InGame.xaml line 275
                {
                    this.RightDown0 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown0).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown0).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown0).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 22: // InGame.xaml line 278
                {
                    this.RightDown1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown1).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown1).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown1).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 23: // InGame.xaml line 281
                {
                    this.RightDown2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown2).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown2).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown2).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 24: // InGame.xaml line 284
                {
                    this.RightDown3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown3).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown3).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown3).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 25: // InGame.xaml line 198
                {
                    this.CanvasLeft = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 26: // InGame.xaml line 199
                {
                    this.LeftBackground = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 27: // InGame.xaml line 214
                {
                    this.leftUp0 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp0).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp0).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp0).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 28: // InGame.xaml line 217
                {
                    this.leftUp1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp1).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp1).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp1).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 29: // InGame.xaml line 220
                {
                    this.leftUp2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp2).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp2).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp2).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 30: // InGame.xaml line 223
                {
                    this.leftUp3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp3).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp3).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp3).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 31: // InGame.xaml line 227
                {
                    this.leftDown0 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftDown0).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftDown0).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 32: // InGame.xaml line 230
                {
                    this.leftDown1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftDown1).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftDown1).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 33: // InGame.xaml line 233
                {
                    this.leftDown2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftDown2).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftDown2).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 34: // InGame.xaml line 236
                {
                    this.leftDown3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftDown3).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftDown3).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 35: // InGame.xaml line 147
                {
                    this.CanvasTop = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 36: // InGame.xaml line 148
                {
                    this.MiddleBackground = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 37: // InGame.xaml line 150
                {
                    global::Windows.UI.Xaml.Controls.Grid element37 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)element37).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 38: // InGame.xaml line 191
                {
                    this.Prueba = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.Prueba).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.Prueba).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 39: // InGame.xaml line 162
                {
                    this.middleLeft0 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft0).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft0).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft0).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 40: // InGame.xaml line 166
                {
                    this.middleLeft1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft1).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft1).DragStarting += this.RightUp0_DragStarting;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft1).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 41: // InGame.xaml line 169
                {
                    this.middleLeft2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft2).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft2).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft2).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 42: // InGame.xaml line 172
                {
                    this.middleLeft3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft3).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft3).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft3).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 43: // InGame.xaml line 176
                {
                    this.middleRight0 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight0).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight0).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight0).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 44: // InGame.xaml line 179
                {
                    this.middleRight1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight1).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight1).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight1).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 45: // InGame.xaml line 182
                {
                    this.middleRight2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight2).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight2).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight2).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 46: // InGame.xaml line 185
                {
                    this.middleRight3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight3).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight3).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight3).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 49: // InGame.xaml line 76
                {
                    this.Grid3 = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    ((global::Windows.UI.Xaml.Controls.GridView)this.Grid3).ItemClick += this.Grid3_ItemClick;
                    ((global::Windows.UI.Xaml.Controls.GridView)this.Grid3).DragItemsStarting += this.Grid3_DragItemsStarting;
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
            switch(connectionId)
            {
            case 1: // InGame.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    InGame_obj1_Bindings bindings = new InGame_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            case 51: // InGame.xaml line 81
                {                    
                    global::Windows.UI.Xaml.Controls.StackPanel element51 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                    InGame_obj51_Bindings bindings = new InGame_obj51_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element51.DataContext);
                    element51.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element51, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element51, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

