using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***GLOBAL_STATUS MODEL***/
  [Table("GLOBAL_STATUS")]
 public partial class Global_Status : IMicron
 {
        public String VARIABLE_NAME {get; set;}
        public String VARIABLE_VALUE {get; set;}
 }
}
