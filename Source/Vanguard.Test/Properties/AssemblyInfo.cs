using System.Reflection;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("Vanguard Test")]
[assembly: AssemblyDescription("The test assembly for testing the Vanguard assembly.")]
[assembly: AssemblyCompany("Veire Productions")]
[assembly: AssemblyProduct("Vanguard.Test")]
[assembly: AssemblyCopyright("Copyright © Veire Productions 2017")]
[assembly: ComVisible(false)]
[assembly: Guid("3b9cb5c5-9eff-4951-944c-bbc916114101")]
[assembly: AssemblyVersion("2.4.0")]
[assembly: AssemblyFileVersion("2.4.0")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif
