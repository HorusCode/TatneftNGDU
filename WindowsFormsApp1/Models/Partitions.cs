using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***PARTITION MODEL***/
  [Table("PARTITIONS")]
 public partial class Partition : IMicron
 {
        public String TABLE_CATALOG {get; set;}
        public String TABLE_SCHEMA {get; set;}
        public String TABLE_NAME {get; set;}
        public String PARTITION_NAME {get; set;}
        public String SUBPARTITION_NAME {get; set;}
        public UInt64 PARTITION_ORDINAL_POSITION {get; set;}
        public UInt64 SUBPARTITION_ORDINAL_POSITION {get; set;}
        public String PARTITION_METHOD {get; set;}
        public String SUBPARTITION_METHOD {get; set;}
        public String PARTITION_EXPRESSION {get; set;}
        public String SUBPARTITION_EXPRESSION {get; set;}
        public String PARTITION_DESCRIPTION {get; set;}
        public UInt64 TABLE_ROWS {get; set;}
        public UInt64 AVG_ROW_LENGTH {get; set;}
        public UInt64 DATA_LENGTH {get; set;}
        public UInt64 MAX_DATA_LENGTH {get; set;}
        public UInt64 INDEX_LENGTH {get; set;}
        public UInt64 DATA_FREE {get; set;}
        public DateTime CREATE_TIME {get; set;}
        public DateTime UPDATE_TIME {get; set;}
        public DateTime CHECK_TIME {get; set;}
        public UInt64 CHECKSUM {get; set;}
        public String PARTITION_COMMENT {get; set;}
        public String NODEGROUP {get; set;}
        public String TABLESPACE_NAME {get; set;}
 }
}
