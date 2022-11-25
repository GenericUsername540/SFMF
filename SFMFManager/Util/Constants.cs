using Microsoft.Win32;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace SFMFManager.Util
{
    public static class Constants
    {
        public static readonly string Version = "v2.0.2";
        public const string SettingsURL = "https://raw.githubusercontent.com/vicjohnson1213/SFMF/manifest/manifest.json";
        public static string SFMFDirectory = $"{AbsoluteInstallDirectory}/SFMF";
        public static string ModSettingsDirectory = $"{SFMFDirectory}/ModSettings";
        public static string ManifestFile = $"{SFMFDirectory}/manifest.json";
        public static string InstalledModsFile = $"{SFMFDirectory}/installedMods.txt";

        private const string SteamRegistry = @"HKEY_CURRENT_USER\Software\Valve\Steam";
        private const string SteamConfig = "config/config.vdf";
        private const string SuperflightDirectory = "steamapps/common/SuperFlight";
        private const string SFManagedDirectory = "superflight_Data/Managed";
        private const string SFAssemblyFileName = "Assembly-CSharp.dll";

        public static string ManagedLocation => $"{AbsoluteInstallDirectory}/superflight_Data/Managed";
        public static string AssemblyLocation => $"{ManagedLocation}/{SFAssemblyFileName}";
        public static string AssemblyBackupLocation => $"{AssemblyLocation}.backup";
        private static string _absoluteInstallDirectory = "D:\SteamLibrary\steamapps\common\SuperFlight";

   
        private static string ExtractValueFromVDF(string vdfLine)
        {
            var re = new Regex(@"\s*""BaseInstallFolder_\d+""\s+""(?<Value>.+)""\s*");
            return re.Match(vdfLine).Groups["Value"].Value;
        }
    }
}
