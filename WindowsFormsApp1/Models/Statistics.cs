using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***STATISTIC MODEL***/
  [Table("STATISTICS")]
 public partial class Statistic : IMicron
 {
        public String TABLE_CATALOG {get; set;}
        public String TABLE_SCHEMA {get; set;}
        public String TABLE_NAME {get; set;}
        public Int64 NON_UNIQUE {get; set;}
        public String INDEX_SCHEMA {get; set;}
        public String INDEX_NAME {get; set;}
        public Int64 SEQ_IN_INDEX {get; set;}
        public String COLUMN_NAME {get; set;}
        public String COLLATION {get; set;}
        public Int64 CARDINALITY {get; set;}
        public Int64 SUB_PART {get; set;}
        public String PACKED {get; set;}
        public String NULLABLE {get; set;}
        public String INDEX_TYPE {get; set;}
        public String COMMENT {get; set;}
        public String INDEX_COMMENT {get; set;}
 }
}
