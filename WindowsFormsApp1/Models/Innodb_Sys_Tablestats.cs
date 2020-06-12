using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***INNODB_SYS_TABLESTAT MODEL***/
  [Table("INNODB_SYS_TABLESTATS")]
 public partial class Innodb_Sys_Tablestat : IMicron
 {
        public UInt64 TABLE_ID {get; set;}
        public String NAME {get; set;}
        public String STATS_INITIALIZED {get; set;}
        public UInt64 NUM_ROWS {get; set;}
        public UInt64 CLUST_INDEX_SIZE {get; set;}
        public UInt64 OTHER_INDEX_SIZE {get; set;}
        public UInt64 MODIFIED_COUNTER {get; set;}
        public UInt64 AUTOINC {get; set;}
        public Int32 REF_COUNT {get; set;}
 }
}
