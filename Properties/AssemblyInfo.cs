using MelonLoader;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle(Melon_Loader_Mod5.BuildInfo.Name)]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(Melon_Loader_Mod5.BuildInfo.Company)]
[assembly: AssemblyProduct(Melon_Loader_Mod5.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + Melon_Loader_Mod5.BuildInfo.Author)]
[assembly: AssemblyTrademark(Melon_Loader_Mod5.BuildInfo.Company)]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
//[assembly: Guid("")]
[assembly: AssemblyVersion(Melon_Loader_Mod5.BuildInfo.Version)]
[assembly: AssemblyFileVersion(Melon_Loader_Mod5.BuildInfo.Version)]
[assembly: NeutralResourcesLanguage("en")]
[assembly: MelonInfo(typeof(Melon_Loader_Mod5.Melon_Loader_Mod5), Melon_Loader_Mod5.BuildInfo.Name, Melon_Loader_Mod5.BuildInfo.Version, Melon_Loader_Mod5.BuildInfo.Author, Melon_Loader_Mod5.BuildInfo.DownloadLink)]


// Create and Setup a MelonModGame to mark a Mod as Universal or Compatible with specific Games.
// If no MelonModGameAttribute is found or any of the Values for any MelonModGame on the Mod is null or empty it will be assumed the Mod is Universal.
// Values for MelonModGame can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame("Stress Level Zero", "BONELAB")]