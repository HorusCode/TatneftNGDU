using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***INNODB_BUFFER_POOL_STAT MODEL***/
  [Table("INNODB_BUFFER_POOL_STATS")]
 public partial class Innodb_Buffer_Pool_Stat : IMicron
 {
        public UInt64 POOL_ID {get; set;}
        public UInt64 POOL_SIZE {get; set;}
        public UInt64 FREE_BUFFERS {get; set;}
        public UInt64 DATABASE_PAGES {get; set;}
        public UInt64 OLD_DATABASE_PAGES {get; set;}
        public UInt64 MODIFIED_DATABASE_PAGES {get; set;}
        public UInt64 PENDING_DECOMPRESS {get; set;}
        public UInt64 PENDING_READS {get; set;}
        public UInt64 PENDING_FLUSH_LRU {get; set;}
        public UInt64 PENDING_FLUSH_LIST {get; set;}
        public UInt64 PAGES_MADE_YOUNG {get; set;}
        public UInt64 PAGES_NOT_MADE_YOUNG {get; set;}
        public Double PAGES_MADE_YOUNG_RATE {get; set;}
        public Double PAGES_MADE_NOT_YOUNG_RATE {get; set;}
        public UInt64 NUMBER_PAGES_READ {get; set;}
        public UInt64 NUMBER_PAGES_CREATED {get; set;}
        public UInt64 NUMBER_PAGES_WRITTEN {get; set;}
        public Double PAGES_READ_RATE {get; set;}
        public Double PAGES_CREATE_RATE {get; set;}
        public Double PAGES_WRITTEN_RATE {get; set;}
        public UInt64 NUMBER_PAGES_GET {get; set;}
        public UInt64 HIT_RATE {get; set;}
        public UInt64 YOUNG_MAKE_PER_THOUSAND_GETS {get; set;}
        public UInt64 NOT_YOUNG_MAKE_PER_THOUSAND_GETS {get; set;}
        public UInt64 NUMBER_PAGES_READ_AHEAD {get; set;}
        public UInt64 NUMBER_READ_AHEAD_EVICTED {get; set;}
        public Double READ_AHEAD_RATE {get; set;}
        public Double READ_AHEAD_EVICTED_RATE {get; set;}
        public UInt64 LRU_IO_TOTAL {get; set;}
        public UInt64 LRU_IO_CURRENT {get; set;}
        public UInt64 UNCOMPRESS_TOTAL {get; set;}
        public UInt64 UNCOMPRESS_CURRENT {get; set;}
 }
}
