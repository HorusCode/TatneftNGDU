using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***SESSION_VARIABLE MODEL***/
  [Table("SESSION_VARIABLES")]
 public partial class Session_Variable : IMicron
 {
        public String VARIABLE_NAME {get; set;}
        public String VARIABLE_VALUE {get; set;}
 }
}
