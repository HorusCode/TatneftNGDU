using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***PROFILING MODEL***/
  [Table("PROFILING")]
 public partial class Profiling : IMicron
 {
        public Int32 QUERY_ID {get; set;}
        public Int32 SEQ {get; set;}
        public String STATE {get; set;}
        public Decimal DURATION {get; set;}
        public Decimal CPU_USER {get; set;}
        public Decimal CPU_SYSTEM {get; set;}
        public Int32 CONTEXT_VOLUNTARY {get; set;}
        public Int32 CONTEXT_INVOLUNTARY {get; set;}
        public Int32 BLOCK_OPS_IN {get; set;}
        public Int32 BLOCK_OPS_OUT {get; set;}
        public Int32 MESSAGES_SENT {get; set;}
        public Int32 MESSAGES_RECEIVED {get; set;}
        public Int32 PAGE_FAULTS_MAJOR {get; set;}
        public Int32 PAGE_FAULTS_MINOR {get; set;}
        public Int32 SWAPS {get; set;}
        public String SOURCE_FUNCTION {get; set;}
        public String SOURCE_FILE {get; set;}
        public Int32 SOURCE_LINE {get; set;}
 }
}
