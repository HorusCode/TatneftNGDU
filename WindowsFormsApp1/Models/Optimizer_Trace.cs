using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***OPTIMIZER_TRACE MODEL***/
  [Table("OPTIMIZER_TRACE")]
 public partial class Optimizer_Trace : IMicron
 {
        public String QUERY {get; set;}
        public String TRACE {get; set;}
        public Int32 MISSING_BYTES_BEYOND_MAX_MEM_SIZE {get; set;}
        public Boolean INSUFFICIENT_PRIVILEGES {get; set;}
 }
}
