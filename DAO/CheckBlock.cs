using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raven.DAO
{
    public class CheckBlock
    {
        private static CheckBlock Instance;

        public static CheckBlock instance 
        {
            get { if (instance == null) instance = new CheckBlock(); return instance; }
            private set => instance = value;
        }
        private CheckBlock() { }
        
        public bool Block (string username , bool block)
        {
            int Result = DataProvider.Instance.ExecuteNonQuery("EXEC BlockAccount @Emails , @isblock", new object[] { username, block });
            return Result > 0;
        }
    }
}
