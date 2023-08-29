using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackendApp.Types;
using BackendApp.Interface;

namespace BackendApp.Factory;

public class OSFactory
{
  
  public IOS Indentify(string minUserFolder)
    {

        if (minUserFolder.Contains("C:"))
        {
            return new Windows("Niels Olesen");
        }
        else if (minUserFolder.Contains("/"))
        {
            return new Linux("Niels Olesen");
        }
        else
            return null;


    }





}
