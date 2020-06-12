using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***INNODB_SYS_TABLESPACE MODEL***/
  [Table("INNODB_SYS_TABLESPACES")]
 public partial class Innodb_Sys_Tablespace : IMicron
 {
        public UInt32 SPACE {get; set;}
        public String NAME {get; set;}
        public UInt32 FLAG {get; set;}
        public String FILE_FORMAT {get; set;}
        public String ROW_FORMAT {get; set;}
        public UInt32 PAGE_SIZE {get; set;}
        public UInt32 ZIP_PAGE_SIZE {get; set;}
 }
}
