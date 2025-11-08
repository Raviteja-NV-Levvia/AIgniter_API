using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIPoweredDefectManagementAssistant.Models
{
    public class TestStepDto
    {
        public int StepNumber { get; set; }
        public string TestStep { get; set; }
        public string TestData { get; set; }
        public string ExpectedResult { get; set; }
        public string Screenshot { get; set; }
        public string ExecutionStatus { get; set; }
    }

}
