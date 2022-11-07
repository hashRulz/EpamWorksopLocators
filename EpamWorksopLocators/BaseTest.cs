using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamWorksopLocators
{
    public abstract class BaseTest
    {
        [TearDown]
        public void Cleanup()
        {
            Driver.Close();
        }
    }
}
