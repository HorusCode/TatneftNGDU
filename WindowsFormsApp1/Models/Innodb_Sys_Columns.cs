using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***INNODB_SYS_COLUMN MODEL***/
  [Table("INNODB_SYS_COLUMNS")]
 public partial class Innodb_Sys_Column : IMicron
 {
        public UInt64 TABLE_ID {get; set;}
        public String NAME {get; set;}
        public UInt64 POS {get; set;}
        public Int32 MTYPE {get; set;}
        public Int32 PRTYPE {get; set;}
        public Int32 LEN {get; set;}
 }
}
