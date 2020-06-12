using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***FILE MODEL***/
  [Table("FILES")]
 public partial class File : IMicron
 {
        public Int64 FILE_ID {get; set;}
        public String FILE_NAME {get; set;}
        public String FILE_TYPE {get; set;}
        public String TABLESPACE_NAME {get; set;}
        public String TABLE_CATALOG {get; set;}
        public String TABLE_SCHEMA {get; set;}
        public String TABLE_NAME {get; set;}
        public String LOGFILE_GROUP_NAME {get; set;}
        public Int64 LOGFILE_GROUP_NUMBER {get; set;}
        public String ENGINE {get; set;}
        public String FULLTEXT_KEYS {get; set;}
        public Int64 DELETED_ROWS {get; set;}
        public Int64 UPDATE_COUNT {get; set;}
        public Int64 FREE_EXTENTS {get; set;}
        public Int64 TOTAL_EXTENTS {get; set;}
        public Int64 EXTENT_SIZE {get; set;}
        public UInt64 INITIAL_SIZE {get; set;}
        public UInt64 MAXIMUM_SIZE {get; set;}
        public UInt64 AUTOEXTEND_SIZE {get; set;}
        public DateTime CREATION_TIME {get; set;}
        public DateTime LAST_UPDATE_TIME {get; set;}
        public DateTime LAST_ACCESS_TIME {get; set;}
        public Int64 RECOVER_TIME {get; set;}
        public Int64 TRANSACTION_COUNTER {get; set;}
        public UInt64 VERSION {get; set;}
        public String ROW_FORMAT {get; set;}
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
        public String STATUS {get; set;}
        public String EXTRA {get; set;}
 }
}
