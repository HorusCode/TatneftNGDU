using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***INNODB_SYS_DATAFILE MODEL***/
  [Table("INNODB_SYS_DATAFILES")]
 public partial class Innodb_Sys_Datafile : IMicron
 {
        public UInt32 SPACE {get; set;}
        public String PATH {get; set;}
 }
}
