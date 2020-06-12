using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***SESSION_STATUS MODEL***/
  [Table("SESSION_STATUS")]
 public partial class Session_Status : IMicron
 {
        public String VARIABLE_NAME {get; set;}
        public String VARIABLE_VALUE {get; set;}
 }
}
