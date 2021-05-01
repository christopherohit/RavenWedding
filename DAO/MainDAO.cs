using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raven.DAO
{
    public class MainDAO
    {
        private static MainDAO instance;

        public static MainDAO Instance 
        {
            get { if (instance == null) instance = new MainDAO(); return instance; }
            private set => instance = value;
        }
        private MainDAO() { }
    }
}
