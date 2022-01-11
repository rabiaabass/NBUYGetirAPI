using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBUYGetirCore.Logging
{
    public interface ILogger
    {
        void Log(string level, string message);
    }
}
