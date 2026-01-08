using Microsoft.Extensions.Logging;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogLevel = Microsoft.Extensions.Logging.LogLevel;

namespace Yale.SprayProcessSCADASystem
{
    public static class UIExtension
    {
        public static Action<UIStyleManager> SetStyleManager;
    }

    public static class LogExtension
    {
        public static Action<string,LogLevel> ShowMesssage;
    }
}
