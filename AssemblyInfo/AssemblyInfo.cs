using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.Versioning;

namespace AssemblyInfo
{
  public static class AssemblyInfo
  {
    /// <summary>
    /// Returns the parent assembly
    /// </summary>
    /// <returns></returns>
    private static Assembly ParentAssembly()
    {
      Assembly _objParentAssembly;
      if (Assembly.GetEntryAssembly() == null)
      {
        _objParentAssembly = Assembly.GetCallingAssembly();
      }
      else
      {
        _objParentAssembly = Assembly.GetEntryAssembly();
      }
      return _objParentAssembly;
    }

    public static String Title
    {
      get
      {
        var applicationTitle = ((AssemblyTitleAttribute)ParentAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false)[0]).Title;
        if (string.IsNullOrWhiteSpace(applicationTitle))
        {
          applicationTitle = ParentAssembly().GetName().Name;
        }
        return applicationTitle;
      }
    }

    public static string Description
    {
      get
      {
        var applicationDescription = ((AssemblyDescriptionAttribute)ParentAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false)[0]).Description;
        return applicationDescription;
      }
    }

    public static string Company
    {
      get
      {
        var applicationCompany = ((AssemblyCompanyAttribute)ParentAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false)[0]).Company;
        return applicationCompany;
      }
    }

    public static string Product
    {
      get
      {
        var applicationProduct = ((AssemblyProductAttribute)ParentAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false)[0]).Product;
        return applicationProduct;
      }
    }

    public static string Copyright
    {
      get
      {
        var applicationCopyright = ((AssemblyCopyrightAttribute)ParentAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false)[0]).Copyright;
        return applicationCopyright;
      }
    }

    public static string Version
    {
      get
      {
        var applicationVersion = ((AssemblyFileVersionAttribute)ParentAssembly().GetCustomAttributes(typeof(AssemblyFileVersionAttribute), false)[0]).Version;
        return applicationVersion;
      }
    }

    // https://visualstudiomagazine.com/articles/2016/12/01/assembly-by-name-and-number.aspx#:~:text=The%20location%20of%20the%20assembly%27s%20version%20number%20appears,for%20the%20Major%2C%20Minor%2C%20Build%20and%20Revision%20values%3A
    public static System.Version FullVersion
    {
      get
      {
        var applicationVersion = ParentAssembly().GetName().Version;
        return applicationVersion;
      }
    }

    public static string Trademark
    {
      get
      {
        var value = ((AssemblyTrademarkAttribute)ParentAssembly().GetCustomAttributes(typeof(AssemblyTrademarkAttribute), false)[0]).Trademark;
        return value;
      }
    }
    public static string Framework
    {
      get
      {
        var applicationFramework = ((TargetFrameworkAttribute)ParentAssembly().GetCustomAttributes(typeof(TargetFrameworkAttribute), false)[0]).FrameworkDisplayName;
        return applicationFramework;
      }
    }

  }
}
