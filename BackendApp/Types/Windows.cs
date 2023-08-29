using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackendApp.Types;
using BackendApp.Interface;

namespace BackendApp.Types;

public class Windows : OS, IOS
{

    public Windows(string userFullName) : base(userFullName)
    {

    }

    
    
    public string ShowOSType()
    {
        return $"Welcome {UserFullName} to Windows, running from backend!";
    }


}
