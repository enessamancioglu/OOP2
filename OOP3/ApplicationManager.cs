using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager
    {
                public void Apply(ICreditManager creditManager, ILoggerService loggerService) //Başvuru yap
        {
            
             
            creditManager.Calculate();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<ICreditManager> credits)
        {

            foreach (var credit in credits)
            {
                credit.Calculate();
            }

        }
    }
}