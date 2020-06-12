using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***COLUMN MODEL***/
  [Table("COLUMNS")]
 public partial class Column : IMicron
 {
        public String TABLE_CATALOG {get; set;}
        public String TABLE_SCHEMA {get; set;}
        public String TABLE_NAME {get; set;}
        public String COLUMN_NAME {get; set;}
        public UInt64 ORDINAL_POSITION {get; set;}
        public String COLUMN_DEFAULT {get; set;}
        public String IS_NULLABLE {get; set;}
        public String DATA_TYPE {get; set;}
        public UInt64 CHARACTER_MAXIMUM_LENGTH {get; set;}
        public UInt64 CHARACTER_OCTET_LENGTH {get; set;}
        public UInt64 NUMERIC_PRECISION {get; set;}
        public UInt64 NUMERIC_SCALE {get; set;}
        public UInt64 DATETIME_PRECISION {get; set;}
        public String CHARACTER_SET_NAME {get; set;}
        public String COLLATION_NAME {get; set;}
        public String COLUMN_TYPE {get; set;}
        public String COLUMN_KEY {get; set;}
        public String EXTRA {get; set;}
        public String PRIVILEGES {get; set;}
        public String COLUMN_COMMENT {get; set;}
 }
}
