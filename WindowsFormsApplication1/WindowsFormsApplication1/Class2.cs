using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Class2
    {
        public bool hihi(int n)
        {
            bool f=true;
              for (int i=2;i<=n-1;i++) 
                { 
                   if (n%i==0) 
                     { 
                            f=false; 
                            break; 
                     } 
                }  
                if (f==false) 
                    return false;
                 else
                    return true;

        }
    }
}
