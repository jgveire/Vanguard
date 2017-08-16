using System;
using System.Reflection;
using System.Resources;

[assembly: AssemblyTitle("Vanguard")]
[assembly: AssemblyDescription("A small library for checking argument values.")]
[assembly: AssemblyCompany("Veire Productions")]
[assembly: AssemblyProduct("Vanguard")]
[assembly: AssemblyCopyright("Copyright © Veire Productions 2017")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyVersion("2.4.0")]
[assembly: AssemblyFileVersion("2.4.0")]
[assembly: NeutralResourcesLanguage("en-US")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif
