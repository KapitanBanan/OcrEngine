﻿#pragma checksum "C:\Users\Boyarin\documents\visual studio 2017\Projects\TextScan\TextScan\Pages\Contact\SelectTextPageContact.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "641B2216FE9FE4F64C002816C12CBEA1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TextScan.Pages.Contact
{
    partial class SelectTextPageContact : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.SelectContact = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 2:
                {
                    this.ScanResult = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3:
                {
                    this.Back = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 15 "..\..\..\..\Pages\Contact\SelectTextPageContact.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Back).Click += this.ClickBack;
                    #line default
                }
                break;
            case 4:
                {
                    this.Continue = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 20 "..\..\..\..\Pages\Contact\SelectTextPageContact.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Continue).Click += this.ClickContinue;
                    #line default
                }
                break;
            case 5:
                {
                    this.Number = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 25 "..\..\..\..\Pages\Contact\SelectTextPageContact.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Number).Click += this.ClickNumber;
                    #line default
                }
                break;
            case 6:
                {
                    this.Name = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 30 "..\..\..\..\Pages\Contact\SelectTextPageContact.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Name).Click += this.ClickName;
                    #line default
                }
                break;
            case 7:
                {
                    this.Mail = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 35 "..\..\..\..\Pages\Contact\SelectTextPageContact.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Mail).Click += this.ClickMail;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
