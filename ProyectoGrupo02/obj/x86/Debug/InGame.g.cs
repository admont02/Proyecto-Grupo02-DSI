﻿#pragma checksum "C:\Users\ADRIAN\Desktop\2.Carrera\2ºCUATRI\Proyecto-Grupo02-DSI\ProyectoGrupo02\InGame.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "CFDF06BA5267FB6584392DC62AB2D29345137391F69C82CF3236F7F765FEFE03"
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
        private class InGame_obj52_Bindings :
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
            private global::System.WeakReference obj52;
            private global::Windows.UI.Xaml.Controls.Image obj53;
            private global::Windows.UI.Xaml.Controls.TextBlock obj54;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj53SourceDisabled = false;
            private static bool isobj54TextDisabled = false;

            private InGame_obj52_BindingsTracking bindingsTracking;

            public InGame_obj52_Bindings()
            {
                this.bindingsTracking = new InGame_obj52_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 32 && columnNumber == 36)
                {
                    isobj53SourceDisabled = true;
                }
                else if (lineNumber == 33 && columnNumber == 40)
                {
                    isobj54TextDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 52: // InGame.xaml line 30
                        this.obj52 = new global::System.WeakReference((global::Windows.UI.Xaml.Controls.StackPanel)target);
                        break;
                    case 53: // InGame.xaml line 32
                        this.obj53 = (global::Windows.UI.Xaml.Controls.Image)target;
                        break;
                    case 54: // InGame.xaml line 33
                        this.obj54 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
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
                            (this.obj52.Target as global::Windows.UI.Xaml.Controls.StackPanel).DataContextChanged -= this.DataContextChangedHandler;
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
                    // InGame.xaml line 32
                    if (!isobj53SourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Image_Source(this.obj53, (global::Windows.UI.Xaml.Media.ImageSource) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::Windows.UI.Xaml.Media.ImageSource), obj), null);
                    }
                }
            }
            private void Update_Precio(global::System.Int32 obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // InGame.xaml line 33
                    if (!isobj54TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj54, obj.ToString(), null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class InGame_obj52_BindingsTracking
            {
                private global::System.WeakReference<InGame_obj52_Bindings> weakRefToBindingObj; 

                public InGame_obj52_BindingsTracking(InGame_obj52_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<InGame_obj52_Bindings>(obj);
                }

                public InGame_obj52_Bindings TryGetBindingObject()
                {
                    InGame_obj52_Bindings bindingObject = null;
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
            private global::Windows.UI.Xaml.Controls.TextBlock obj49;
            private global::Windows.UI.Xaml.Controls.GridView obj50;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj49TextDisabled = false;
            private static bool isobj50ItemsSourceDisabled = false;

            private InGame_obj1_BindingsTracking bindingsTracking;

            public InGame_obj1_Bindings()
            {
                this.bindingsTracking = new InGame_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 82 && columnNumber == 43)
                {
                    isobj49TextDisabled = true;
                }
                else if (lineNumber == 27 && columnNumber == 55)
                {
                    isobj50ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 49: // InGame.xaml line 82
                        this.obj49 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    case 50: // InGame.xaml line 25
                        this.obj50 = (global::Windows.UI.Xaml.Controls.GridView)target;
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
                    // InGame.xaml line 82
                    if (!isobj49TextDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj49, obj.ToString(), null);
                    }
                }
            }
            private void Update_Objects(global::System.Collections.ObjectModel.ObservableCollection<global::ProyectoGrupo02.VMObject> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // InGame.xaml line 25
                    if (!isobj50ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj50, obj, null);
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
            case 2: // InGame.xaml line 71
                {
                    this.Pause = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.Pause).Click += this.Click_Pause;
                }
                break;
            case 3: // InGame.xaml line 90
                {
                    global::Windows.UI.Xaml.Controls.Button element3 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element3).Click += this.Coin_Clicker;
                }
                break;
            case 4: // InGame.xaml line 102
                {
                    this.ProgressBar = (global::Windows.UI.Xaml.Controls.ProgressBar)(target);
                }
                break;
            case 5: // InGame.xaml line 270
                {
                    this.Pot1 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 6: // InGame.xaml line 293
                {
                    global::Windows.UI.Xaml.Controls.Button element6 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element6).Click += this.add_Click;
                }
                break;
            case 10: // InGame.xaml line 279
                {
                    global::Windows.UI.Xaml.Controls.Button element10 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element10).Click += this.Lab_Click;
                }
                break;
            case 14: // InGame.xaml line 258
                {
                    this.Papelera = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.Papelera).Drop += this.Papelera_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.Papelera).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 15: // InGame.xaml line 205
                {
                    this.CanvasRight = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 16: // InGame.xaml line 206
                {
                    this.RightBackground = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 17: // InGame.xaml line 222
                {
                    this.RightUp0 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp0).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp0).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp0).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 18: // InGame.xaml line 225
                {
                    this.RightUp1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp1).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp1).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp1).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 19: // InGame.xaml line 228
                {
                    this.RightUp2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp2).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp2).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp2).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 20: // InGame.xaml line 231
                {
                    this.RightUp3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp3).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp3).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightUp3).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 21: // InGame.xaml line 235
                {
                    this.RightDown0 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown0).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown0).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown0).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 22: // InGame.xaml line 238
                {
                    this.RightDown1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown1).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown1).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown1).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 23: // InGame.xaml line 241
                {
                    this.RightDown2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown2).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown2).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown2).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 24: // InGame.xaml line 244
                {
                    this.RightDown3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown3).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown3).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.RightDown3).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 25: // InGame.xaml line 157
                {
                    this.CanvasLeft = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 26: // InGame.xaml line 158
                {
                    this.LeftBackground = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 27: // InGame.xaml line 174
                {
                    this.leftUp0 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp0).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp0).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp0).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 28: // InGame.xaml line 177
                {
                    this.leftUp1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp1).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp1).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp1).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 29: // InGame.xaml line 180
                {
                    this.leftUp2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp2).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp2).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp2).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 30: // InGame.xaml line 183
                {
                    this.leftUp3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp3).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp3).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftUp3).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 31: // InGame.xaml line 187
                {
                    this.leftDown0 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftDown0).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftDown0).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 32: // InGame.xaml line 190
                {
                    this.leftDown1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftDown1).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftDown1).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 33: // InGame.xaml line 193
                {
                    this.leftDown2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftDown2).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftDown2).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 34: // InGame.xaml line 196
                {
                    this.leftDown3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftDown3).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.leftDown3).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 35: // InGame.xaml line 106
                {
                    this.CanvasTop = (global::Windows.UI.Xaml.Controls.Canvas)(target);
                }
                break;
            case 36: // InGame.xaml line 107
                {
                    this.MiddleBackground = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 37: // InGame.xaml line 109
                {
                    global::Windows.UI.Xaml.Controls.Grid element37 = (global::Windows.UI.Xaml.Controls.Grid)(target);
                    ((global::Windows.UI.Xaml.Controls.Grid)element37).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 38: // InGame.xaml line 150
                {
                    this.Prueba = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.Prueba).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.Prueba).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 39: // InGame.xaml line 121
                {
                    this.middleLeft0 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft0).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft0).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft0).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 40: // InGame.xaml line 125
                {
                    this.middleLeft1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft1).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft1).DragStarting += this.RightUp0_DragStarting;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft1).DragOver += this.Ellipse_DragOver;
                }
                break;
            case 41: // InGame.xaml line 128
                {
                    this.middleLeft2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft2).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft2).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft2).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 42: // InGame.xaml line 131
                {
                    this.middleLeft3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft3).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft3).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleLeft3).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 43: // InGame.xaml line 135
                {
                    this.middleRight0 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight0).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight0).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight0).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 44: // InGame.xaml line 138
                {
                    this.middleRight1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight1).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight1).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight1).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 45: // InGame.xaml line 141
                {
                    this.middleRight2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight2).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight2).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight2).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 46: // InGame.xaml line 144
                {
                    this.middleRight3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight3).Drop += this.Ellipse_Drop;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight3).DragOver += this.Ellipse_DragOver;
                    ((global::Windows.UI.Xaml.Controls.Image)this.middleRight3).DragStarting += this.RightUp0_DragStarting;
                }
                break;
            case 49: // InGame.xaml line 82
                {
                    this.Money = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 50: // InGame.xaml line 25
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
            case 52: // InGame.xaml line 30
                {                    
                    global::Windows.UI.Xaml.Controls.StackPanel element52 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                    InGame_obj52_Bindings bindings = new InGame_obj52_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(element52.DataContext);
                    element52.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element52, bindings);
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element52, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

