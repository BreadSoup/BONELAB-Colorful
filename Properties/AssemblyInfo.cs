using MelonLoader;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle(Colorful.BuildInfo.Name)]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(Colorful.BuildInfo.Company)]
[assembly: AssemblyProduct(Colorful.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + Colorful.BuildInfo.Author)]
[assembly: AssemblyTrademark(Colorful.BuildInfo.Company)]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
//[assembly: Guid("")]
[assembly: AssemblyVersion(Colorful.BuildInfo.Version)]
[assembly: AssemblyFileVersion(Colorful.BuildInfo.Version)]
[assembly: NeutralResourcesLanguage("en")]
[assembly: MelonInfo(typeof(Colorful.Main), Colorful.BuildInfo.Name, Colorful.BuildInfo.Version, Colorful.BuildInfo.Author, Colorful.BuildInfo.DownloadLink)]


// Create and Setup a MelonModGame to mark a Mod as Universal or Compatible with specific Games.
// If no MelonModGameAttribute is found or any of the Values for any MelonModGame on the Mod is null or empty it will be assumed the Mod is Universal.
// Values for MelonModGame can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame("Stress Level Zero", "BONELAB")]