using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***INNODB_CMPMEM MODEL***/
  [Table("INNODB_CMPMEM")]
 public partial class Innodb_Cmpmem : IMicron
 {
        public Int32 page_size {get; set;}
        public Int32 buffer_pool_instance {get; set;}
        public Int32 pages_used {get; set;}
        public Int32 pages_free {get; set;}
        public Int64 relocation_ops {get; set;}
        public Int32 relocation_time {get; set;}
 }
}
