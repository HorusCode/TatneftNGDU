using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***INNODB_FT_INDEX_TABLE MODEL***/
  [Table("INNODB_FT_INDEX_TABLE")]
 public partial class Innodb_Ft_Index_Table : IMicron
 {
        public String WORD {get; set;}
        public UInt64 FIRST_DOC_ID {get; set;}
        public UInt64 LAST_DOC_ID {get; set;}
        public UInt64 DOC_COUNT {get; set;}
        public UInt64 DOC_ID {get; set;}
        public UInt64 POSITION {get; set;}
 }
}
