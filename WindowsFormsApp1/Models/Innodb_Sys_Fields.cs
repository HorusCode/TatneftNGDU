using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***INNODB_SYS_FIELD MODEL***/
  [Table("INNODB_SYS_FIELDS")]
 public partial class Innodb_Sys_Field : IMicron
 {
        public UInt64 INDEX_ID {get; set;}
        public String NAME {get; set;}
        public UInt32 POS {get; set;}
 }
}
