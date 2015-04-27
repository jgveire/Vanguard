using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("Vanguard")]
[assembly: AssemblyDescription("A small library for checking argument values.")]
[assembly: AssemblyCompany("Puur Software")]
[assembly: AssemblyProduct("Vanguard")]
[assembly: AssemblyCopyright("Copyright © Puur Software 2015")]
[assembly: AssemblyCulture("")]
[assembly: CLSCompliant(true)]
[assembly: AssemblyVersion("1.0.2")]
[assembly: AssemblyFileVersion("1.0.2")]
[assembly: NeutralResourcesLanguageAttribute("en-US")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif
