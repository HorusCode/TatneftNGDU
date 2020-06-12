using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***COLLATION_CHARACTER_SET_APPLICABILITY MODEL***/
  [Table("COLLATION_CHARACTER_SET_APPLICABILITY")]
 public partial class Collation_Character_Set_Applicability : IMicron
 {
        public String COLLATION_NAME {get; set;}
        public String CHARACTER_SET_NAME {get; set;}
 }
}
