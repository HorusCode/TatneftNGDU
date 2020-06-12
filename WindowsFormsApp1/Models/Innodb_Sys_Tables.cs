using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***INNODB_SYS_TABLE MODEL***/
  [Table("INNODB_SYS_TABLES")]
 public partial class Innodb_Sys_Table : IMicron
 {
        public UInt64 TABLE_ID {get; set;}
        public String NAME {get; set;}
        public Int32 FLAG {get; set;}
        public Int32 N_COLS {get; set;}
        public Int32 SPACE {get; set;}
        public String FILE_FORMAT {get; set;}
        public String ROW_FORMAT {get; set;}
        public UInt32 ZIP_PAGE_SIZE {get; set;}
 }
}
