# AssemblyInfo
Library returning assembly info of the parent assembly

Code sample :
```C#
AssemblyInfo.AssemblyInfo assemblyInfo = new AssemblyInfo.AssemblyInfo();
Console.WriteLine($"Title={assemblyInfo.Title}");
Console.WriteLine($"Description={assemblyInfo.Description}");
Console.WriteLine($"Company={assemblyInfo.Company}");
Console.WriteLine($"Product={assemblyInfo.Product}");
Console.WriteLine($"Copyright={assemblyInfo.Copyright}");
Console.WriteLine($"Version={assemblyInfo.Version}");
Console.WriteLine($"Full version = Major:{assemblyInfo.FullVersion.Major}, Minor:{assemblyInfo.FullVersion.Minor}, Revision:{assemblyInfo.FullVersion.Revision}");
Console.WriteLine($"Trademark={assemblyInfo.Trademark}");
Console.WriteLine($"Framework={assemblyInfo.Framework}");
```

	  

