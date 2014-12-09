namespace System
open System.Reflection

[<assembly: AssemblyProductAttribute("MyLibrary")>]
[<assembly: AssemblyCompanyAttribute("Company")>]
[<assembly: AssemblyCopyrightAttribute("Company")>]
[<assembly: AssemblyVersionAttribute("1.3.1068")>]
[<assembly: AssemblyFileVersionAttribute("1.3.1068")>]
[<assembly: AssemblyInformationalVersionAttribute("1.3.1068")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.3.1068"
