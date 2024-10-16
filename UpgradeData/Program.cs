﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace UpgradeData
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
#if (!DEBUG)
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new UpgradeService()
            };
            ServiceBase.Run(ServicesToRun);
#else
            UpgradeService myServ = new UpgradeService();

            myServ.ThingsToDo();

#endif
        }
    }
}
