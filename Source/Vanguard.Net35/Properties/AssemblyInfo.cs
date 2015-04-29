using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;

[assembly: AssemblyTitle("Vanguard for .NET 2.0")]
[assembly: AssemblyDescription("A small library for checking argument values.")]
[assembly: AssemblyCompany("Puur Software")]
[assembly: AssemblyProduct("Vanguard")]
[assembly: AssemblyCopyright("Copyright © Puur Software 2015")]
[assembly: AssemblyCulture("")]
[assembly: Guid("f935f687-452f-46a4-ae40-4879c096db2f")]
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]
[assembly: AssemblyVersion("1.1.0")]
[assembly: AssemblyFileVersion("1.1.0")]
[assembly: NeutralResourcesLanguage("en-US")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif