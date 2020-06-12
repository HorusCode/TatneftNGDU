using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***INNODB_SYS_FOREIGN MODEL***/
  [Table("INNODB_SYS_FOREIGN")]
 public partial class Innodb_Sys_Foreign : IMicron
 {
        public String ID {get; set;}
        public String FOR_NAME {get; set;}
        public String REF_NAME {get; set;}
        public UInt32 N_COLS {get; set;}
        public UInt32 TYPE {get; set;}
 }
}
