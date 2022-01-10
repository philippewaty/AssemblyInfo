using System;

namespace AssemblyInfoTest
{
  class Program
  {
    static void Main(string[] args)
    {
      AssemblyInfo.AssemblyInfo assemblyInfo = new AssemblyInfo.AssemblyInfo();
      Console.WriteLine($"Title={assemblyInfo.GetTitle}");
      Console.WriteLine($"Description={assemblyInfo.GetDescription}");
      Console.WriteLine($"Company={assemblyInfo.GetCompany}");
      Console.WriteLine($"Product={assemblyInfo.GetProduct}");
      Console.WriteLine($"Copyright={assemblyInfo.GetCopyright}");
      Console.WriteLine($"Version={assemblyInfo.GetVersion}");
      Console.WriteLine($"Full version = Major:{assemblyInfo.GetFullVersion.Major}, Minor:{assemblyInfo.GetFullVersion.Minor}, Revision:{assemblyInfo.GetFullVersion.Revision}");
      Console.WriteLine($"Trademark={assemblyInfo.GetTrademark}");
      Console.WriteLine($"Framework={assemblyInfo.GetFramework}");
      Console.ReadKey();
    }
  }
}
