using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElementBase_Template.PLC;

namespace ElementBase_Template.PLC.PLC1
{
    public class QuanTracIndex_Tag
    {
        public Tag codIndex_Tag { get; set; } = new Tag("codIndex_Tag");
        public Tag tssIndex_Tag { get; set; } = new Tag("tssIndex_Tag");
        public Tag phIndex_Tag { get; set; } = new Tag("phIndex_Tag");
        public Tag colorIndex_Tag { get; set; } = new Tag("colorIndex_Tag");
        public Tag temperIndex_Tag { get; set; } = new Tag("temperIndex_Tag");
        public Tag amoniIndex_Tag { get; set; } = new Tag("amoniIndex_Tag");

        public Tag flowInTotalIndex_Tag { get; set; } = new Tag("flowInTotalIndex_Tag");
        public Tag flowInCapIndex_Tag { get; set; } = new Tag("flowInCapIndex_Tag");
        public Tag flowOutTotalIndex_Tag { get; set; } = new Tag("flowOutTotalIndex_Tag");
        public Tag flowOutCapIndex_Tag { get; set; } = new Tag("flowOutCapIndex_Tag");


    }
}
