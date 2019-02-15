﻿using System.IO;

namespace EnvironmentModules
{
    /// <summary>
    /// This enum defines all types that Environment Modules can have.
    /// </summary>
    public enum EnvironmentModuleType
    {
        /// <summary>
        /// The module is a common module that has dependencies and provides functions etc.
        /// </summary>
        Default,
        /// <summary>
        /// The module is used to load any concrete (default) module with the same name. This type is used by automatically generated modules.
        /// </summary>
        Meta,
        /// <summary>
        /// This module does provide functions, aliases etc, but can only be loaded by a default module as dependency.
        /// </summary>
        Abstract
    }

    /// <summary>
    /// This class contains basic information about an environment module. This information is written to the cache in order to improve performance.
    /// </summary>
    public class EnvironmentModuleInfoBase
    {
        /// <summary>
        /// The base directory of the environment module. Should be the same as for the underlaying 
        /// PowerShell module.
        /// </summary>
        public string ModuleBase { get; set; }

        /// <summary>
        /// The full name of the module. This name can be used to load the module with the help of the powershell-environment.
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The short name of the module.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The version of the application or library.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// The machine code of the module (e.g. x86, x64, arm...).
        /// </summary>
        public string Architecture { get; set; }

        /// <summary>
        /// Additional infos like compiler or compilation flags (e.g. MSVC15, gcc, ...).
        /// </summary>
        public string AdditionalOptions { get; set; }

        /// <summary>
        /// Specifies the type of the module.
        /// </summary>
        public EnvironmentModuleType ModuleType { get; set; }

        public EnvironmentModuleInfoBase(string fullName,
            string moduleBase,
            string name,
            string version,
            string architecture,
            string additionalOptions = "",
            EnvironmentModuleType moduleType = EnvironmentModuleType.Default)
        {
            FullName = fullName;
            ModuleBase = moduleBase;
            ModuleType = moduleType;
            Name = name;
            Version = version;
            Architecture = architecture;
            AdditionalOptions = additionalOptions;
        }
    }
}
