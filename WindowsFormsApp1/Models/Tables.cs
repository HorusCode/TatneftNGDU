using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***TABLE MODEL***/
  [Table("TABLES")]
 public partial class Table : IMicron
 {
        public String TABLE_CATALOG {get; set;}
        public String TABLE_SCHEMA {get; set;}
        public String TABLE_NAME {get; set;}
        public String TABLE_TYPE {get; set;}
        public String ENGINE {get; set;}
        public UInt64 VERSION {get; set;}
        public String ROW_FORMAT {get; set;}
        public UInt64 TABLE_ROWS {get; set;}
        public UInt64 AVG_ROW_LENGTH {get; set;}
        public UInt64 DATA_LENGTH {get; set;}
        public UInt64 MAX_DATA_LENGTH {get; set;}
        public UInt64 INDEX_LENGTH {get; set;}
        public UInt64 DATA_FREE {get; set;}
        public UInt64 AUTO_INCREMENT {get; set;}
        public DateTime CREATE_TIME {get; set;}
        public DateTime UPDATE_TIME {get; set;}
        public DateTime CHECK_TIME {get; set;}
        public String TABLE_COLLATION {get; set;}
        public UInt64 CHECKSUM {get; set;}
        public String CREATE_OPTIONS {get; set;}
        public String TABLE_COMMENT {get; set;}
 }
}
