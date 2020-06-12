using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***INNODB_SYS_INDEX MODEL***/
  [Table("INNODB_SYS_INDEXES")]
 public partial class Innodb_Sys_Index : IMicron
 {
        public UInt64 INDEX_ID {get; set;}
        public String NAME {get; set;}
        public UInt64 TABLE_ID {get; set;}
        public Int32 TYPE {get; set;}
        public Int32 N_FIELDS {get; set;}
        public Int32 PAGE_NO {get; set;}
        public Int32 SPACE {get; set;}
 }
}
