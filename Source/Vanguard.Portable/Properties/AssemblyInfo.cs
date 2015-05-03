using System;
using System.Reflection;
using System.Resources;

[assembly: AssemblyTitle("Vanguard")]
[assembly: AssemblyDescription("A small library for checking argument values.")]
[assembly: AssemblyCompany("Puur Software")]
[assembly: AssemblyProduct("Vanguard")]
[assembly: AssemblyCopyright("Copyright © Puur Software 2015")]
[assembly: AssemblyCulture("")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyVersion("2.0.1")]
[assembly: AssemblyFileVersion("2.0.1")]
[assembly: NeutralResourcesLanguage("en-US")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif
