﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Supaf_Html.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.4.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("workstation id=EvolutionT41N.mssql.somee.com;packet size=4096;user id=EvolutionT4" +
            "1N_SQLLogin_1;pwd=rwn2kpt4lx;data source=EvolutionT41N.mssql.somee.com;persist s" +
            "ecurity info=False;initial catalog=EvolutionT41N")]
        public string strConexao {
            get {
                return ((string)(this["strConexao"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.ConnectionString)]
        [global::System.Configuration.DefaultSettingValueAttribute("Data Source=DESKTOP-MMKRG82;Integrated Security=True;Connect Timeout=30;Encrypt=F" +
            "alse;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailove" +
            "r=False")]
        public string ConexaoLocal {
            get {
                return ((string)(this["ConexaoLocal"]));
            }
        }
    }
}
