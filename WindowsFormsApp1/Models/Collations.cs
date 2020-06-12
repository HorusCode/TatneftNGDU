using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***COLLATION MODEL***/
  [Table("COLLATIONS")]
 public partial class Collation : IMicron
 {
        public String COLLATION_NAME {get; set;}
        public String CHARACTER_SET_NAME {get; set;}
        public Int64 ID {get; set;}
        public String IS_DEFAULT {get; set;}
        public String IS_COMPILED {get; set;}
        public Int64 SORTLEN {get; set;}
 }
}
