﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Main {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class acc_journ_sett : global::System.Configuration.ApplicationSettingsBase {
        
        private static acc_journ_sett defaultInstance = ((acc_journ_sett)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new acc_journ_sett())));
        
        public static acc_journ_sett Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool widevw {
            get {
                return ((bool)(this["widevw"]));
            }
            set {
                this["widevw"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int dgvborder {
            get {
                return ((int)(this["dgvborder"]));
            }
            set {
                this["dgvborder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool db_jrn_strt {
            get {
                return ((bool)(this["db_jrn_strt"]));
            }
            set {
                this["db_jrn_strt"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool dynam_jrn {
            get {
                return ((bool)(this["dynam_jrn"]));
            }
            set {
                this["dynam_jrn"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IO {
            get {
                return ((bool)(this["IO"]));
            }
            set {
                this["IO"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string IOpwrd {
            get {
                return ((string)(this["IOpwrd"]));
            }
            set {
                this["IOpwrd"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool shw_extra_date {
            get {
                return ((bool)(this["shw_extra_date"]));
            }
            set {
                this["shw_extra_date"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool autosave {
            get {
                return ((bool)(this["autosave"]));
            }
            set {
                this["autosave"] = value;
            }
        }
    }
}
