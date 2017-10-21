#region Using directives

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.ConstrainedExecution;

#endregion

//
// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
//
[assembly: AssemblyTitle(@"")]
[assembly: AssemblyDescription(@"")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany(@"Ufba")]
[assembly: AssemblyProduct(@"ShHome")]
[assembly: AssemblyCopyright("")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: System.Resources.NeutralResourcesLanguage("en")]

//
// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:

[assembly: AssemblyVersion(@"1.0.0.0")]
[assembly: ComVisible(false)]
[assembly: CLSCompliant(true)]
[assembly: ReliabilityContract(Consistency.MayCorruptProcess, Cer.None)]

//
// Make the Dsl project internally visible to the DslPackage assembly
//
[assembly: InternalsVisibleTo(@"Ufba.ShHome.DslPackage, PublicKey=002400000480000094000000060200000024000052534131000400000100010049058474BBF64CC4465165691947A0EA2D87AA29E4AFF9D5A626103855CC6C14A522F7E19CEE068472A746D71F3884F3681F5244924552CCAF2C4EB7A13016C161262751702012D607026F19C18D25FD133B9DE838D774E00E320B9D59E8147C7E0D04EBF1B2A425E4E09A688887FA99EA5D8C846F6ACA0ED09EC6670AC67BB6")]