﻿#pragma checksum "C:\Users\Boyarin\documents\visual studio 2017\Projects\TextScan\TextScan\Pages\Appointment\SelectTextAppoinmentPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "495D635572441C1985165A6A9E2E46DD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TextScan
{
    partial class SelectTextAppoinmentPage : 
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
                    this.ChoosePageAppointment1 = (global::Windows.UI.Xaml.Controls.Grid)(target);
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
                    #line 15 "..\..\..\..\Pages\Appointment\SelectTextAppoinmentPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Back).Click += this.ClickBack;
                    #line default
                }
                break;
            case 4:
                {
                    this.Continue = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 20 "..\..\..\..\Pages\Appointment\SelectTextAppoinmentPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Continue).Click += this.ClickContinue;
                    #line default
                }
                break;
            case 5:
                {
                    this.Subject = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 25 "..\..\..\..\Pages\Appointment\SelectTextAppoinmentPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Subject).Click += this.ClickSubject;
                    #line default
                }
                break;
            case 6:
                {
                    this.Date = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 30 "..\..\..\..\Pages\Appointment\SelectTextAppoinmentPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Date).Click += this.ClickDate;
                    #line default
                }
                break;
            case 7:
                {
                    this.Details = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 35 "..\..\..\..\Pages\Appointment\SelectTextAppoinmentPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.Details).Click += this.ClickDetails;
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

