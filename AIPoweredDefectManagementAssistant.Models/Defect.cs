using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIPoweredDefectManagementAssistant.Models
{
    public class Defect
    {
        public string TestCaseId { get; set; }
        public string Title { get; set; }
        public string Module { get; set; }
        public string ExpectedResult { get; set; }
        public string ActualResult { get; set; }
        public string Status { get; set; }

        public List<TestStepDto> Steps { get; set; } = new();

        // AI generated fields
        public string GeneratedDescription { get; set; }
        public string GeneratedStepsToReproduce { get; set; }
        public string SuggestedSeverity { get; set; }
        public string SuggestedPriority { get; set; }

        public float[] Embedding { get; set; }
    }

}
