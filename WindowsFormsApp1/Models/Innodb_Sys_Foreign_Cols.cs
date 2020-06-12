using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***INNODB_SYS_FOREIGN_COL MODEL***/
  [Table("INNODB_SYS_FOREIGN_COLS")]
 public partial class Innodb_Sys_Foreign_Col : IMicron
 {
        public String ID {get; set;}
        public String FOR_COL_NAME {get; set;}
        public String REF_COL_NAME {get; set;}
        public UInt32 POS {get; set;}
 }
}
