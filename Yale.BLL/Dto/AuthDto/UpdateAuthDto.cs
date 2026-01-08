using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yale.BLL
{
    public  class UpdateAuthDto:BaseDto
    {
        public string Role { get; set; }
        public bool ControlModule { get; set; }
        public bool MonitorModule { get; set; }
        public bool RecipeModule { get; set; }
        public bool LogModule { get; set; }
        public bool ReportModule { get; set; }
        public bool ChartModule { get; set; }
        public bool ParamModule { get; set; }
    }
}
