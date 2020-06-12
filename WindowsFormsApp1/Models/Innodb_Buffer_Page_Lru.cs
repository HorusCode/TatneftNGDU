using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***INNODB_BUFFER_PAGE_LRU MODEL***/
  [Table("INNODB_BUFFER_PAGE_LRU")]
 public partial class Innodb_Buffer_Page_Lru : IMicron
 {
        public UInt64 POOL_ID {get; set;}
        public UInt64 LRU_POSITION {get; set;}
        public UInt64 SPACE {get; set;}
        public UInt64 PAGE_NUMBER {get; set;}
        public String PAGE_TYPE {get; set;}
        public UInt64 FLUSH_TYPE {get; set;}
        public UInt64 FIX_COUNT {get; set;}
        public String IS_HASHED {get; set;}
        public UInt64 NEWEST_MODIFICATION {get; set;}
        public UInt64 OLDEST_MODIFICATION {get; set;}
        public UInt64 ACCESS_TIME {get; set;}
        public String TABLE_NAME {get; set;}
        public String INDEX_NAME {get; set;}
        public UInt64 NUMBER_RECORDS {get; set;}
        public UInt64 DATA_SIZE {get; set;}
        public UInt64 COMPRESSED_SIZE {get; set;}
        public String COMPRESSED {get; set;}
        public String IO_FIX {get; set;}
        public String IS_OLD {get; set;}
        public UInt64 FREE_PAGE_CLOCK {get; set;}
 }
}
