using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***GLOBAL_VARIABLE MODEL***/
  [Table("GLOBAL_VARIABLES")]
 public partial class Global_Variable : IMicron
 {
        public String VARIABLE_NAME {get; set;}
        public String VARIABLE_VALUE {get; set;}
 }
}
