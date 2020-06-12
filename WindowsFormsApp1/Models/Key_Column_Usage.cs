using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***KEY_COLUMN_USAGE MODEL***/
  [Table("KEY_COLUMN_USAGE")]
 public partial class Key_Column_Usage : IMicron
 {
        public String CONSTRAINT_CATALOG {get; set;}
        public String CONSTRAINT_SCHEMA {get; set;}
        public String CONSTRAINT_NAME {get; set;}
        public String TABLE_CATALOG {get; set;}
        public String TABLE_SCHEMA {get; set;}
        public String TABLE_NAME {get; set;}
        public String COLUMN_NAME {get; set;}
        public Int64 ORDINAL_POSITION {get; set;}
        public Int64 POSITION_IN_UNIQUE_CONSTRAINT {get; set;}
        public String REFERENCED_TABLE_SCHEMA {get; set;}
        public String REFERENCED_TABLE_NAME {get; set;}
        public String REFERENCED_COLUMN_NAME {get; set;}
 }
}
