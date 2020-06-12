using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***INNODB_CMP MODEL***/
  [Table("INNODB_CMP")]
 public partial class Innodb_Cmp : IMicron
 {
        public Int32 page_size {get; set;}
        public Int32 compress_ops {get; set;}
        public Int32 compress_ops_ok {get; set;}
        public Int32 compress_time {get; set;}
        public Int32 uncompress_ops {get; set;}
        public Int32 uncompress_time {get; set;}
 }
}
