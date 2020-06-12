using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***CHARACTER_SET MODEL***/
  [Table("CHARACTER_SETS")]
 public partial class Character_Set : IMicron
 {
        public String CHARACTER_SET_NAME {get; set;}
        public String DEFAULT_COLLATE_NAME {get; set;}
        public String DESCRIPTION {get; set;}
        public Int64 MAXLEN {get; set;}
 }
}
