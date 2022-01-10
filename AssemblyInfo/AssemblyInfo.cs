using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Runtime.Versioning;

namespace AssemblyInfo
{
  public class AssemblyInfo
  {
    private Assembly _objParentAssembly = null;

    private Assembly ParentAssembly()
    {
      if (_objParentAssembly == null)
      {
        if (Assembly.GetEntryAssembly() == null)
        {
          _objParentAssembly = Assembly.GetCallingAssembly();
        }
        else
        {
          _objParentAssembly = Assembly.GetEntryAssembly();
        }
      }
      return _objParentAssembly;
    }

    public AssemblyInfo()
    {
      _objParentAssembly = ParentAssembly();
    }

    public String GetTitle
    {
      get
      {
        var applicationTitle = ((AssemblyTitleAttribute)_objParentAssembly.GetCustomAttributes(typeof(AssemblyTitleAttribute), false)[0]).Title;
        if (string.IsNullOrWhiteSpace(applicationTitle))
        {
          applicationTitle = _objParentAssembly.GetName().Name;
        }
        return applicationTitle;
      }
    }

    public string GetDescription
    {
      get
      {
        var applicationDescription = ((AssemblyDescriptionAttribute)_objParentAssembly.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false)[0]).Description;
        return applicationDescription;
      }
    }

    public string GetCompany
    {
      get
      {
        var applicationCompany = ((AssemblyCompanyAttribute)_objParentAssembly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), false)[0]).Company;
        return applicationCompany;
      }
    }

    public string GetProduct
    {
      get
      {
        var applicationProduct = ((AssemblyProductAttribute)_objParentAssembly.GetCustomAttributes(typeof(AssemblyProductAttribute), false)[0]).Product;
        return applicationProduct;
      }
    }

    public string GetCopyright
    {
      get
      {
        var applicationCopyright = ((AssemblyCopyrightAttribute)_objParentAssembly.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false)[0]).Copyright;
        return applicationCopyright;
      }
    }

    public string GetVersion
    {
      get
      {
        var applicationVersion = ((AssemblyFileVersionAttribute)_objParentAssembly.GetCustomAttributes(typeof(AssemblyFileVersionAttribute), false)[0]).Version;
        return applicationVersion;
      }
    }

    // https://visualstudiomagazine.com/articles/2016/12/01/assembly-by-name-and-number.aspx#:~:text=The%20location%20of%20the%20assembly%27s%20version%20number%20appears,for%20the%20Major%2C%20Minor%2C%20Build%20and%20Revision%20values%3A
    public System.Version GetFullVersion
    {
      get
      {
        var applicationVersion = _objParentAssembly.GetName().Version;
        return applicationVersion;
      }
    }

    public string GetTrademark
    {
      get
      {
        var value = ((AssemblyTrademarkAttribute)_objParentAssembly.GetCustomAttributes(typeof(AssemblyTrademarkAttribute), false)[0]).Trademark;
        return value;
      }
    }
    public string GetFramework
    {
      get
      {
        var applicationFramework = ((TargetFrameworkAttribute)_objParentAssembly.GetCustomAttributes(typeof(TargetFrameworkAttribute), false)[0]).FrameworkDisplayName;
        return applicationFramework;
      }
    }

  }
}
