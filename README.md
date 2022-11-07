# AssemblyInfo
Library returning assembly info of the parent assembly

Code sample :
```C#
Console.WriteLine($"Title={AssemblyInfo.AssemblyInfo.Title}");
Console.WriteLine($"Description={AssemblyInfo.AssemblyInfo.Description}");
Console.WriteLine($"Company={AssemblyInfo.AssemblyInfo.Company}");
Console.WriteLine($"Product={AssemblyInfo.AssemblyInfo.Product}");
Console.WriteLine($"Copyright={AssemblyInfo.AssemblyInfo.Copyright}");
Console.WriteLine($"Version={AssemblyInfo.AssemblyInfo.Version}");
Console.WriteLine($"Full version = Major:{AssemblyInfo.AssemblyInfo.FullVersion.Major}, Minor:{AssemblyInfo.AssemblyInfo.FullVersion.Minor}, Revision:{AssemblyInfo.AssemblyInfo.FullVersion.Revision}");
Console.WriteLine($"Trademark={AssemblyInfo.AssemblyInfo.Trademark}");
Console.WriteLine($"Framework={AssemblyInfo.AssemblyInfo.Framework}");
```

	  

