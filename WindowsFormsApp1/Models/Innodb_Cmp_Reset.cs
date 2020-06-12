using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***INNODB_CMP_RESET MODEL***/
  [Table("INNODB_CMP_RESET")]
 public partial class Innodb_Cmp_Reset : IMicron
 {
        public Int32 page_size {get; set;}
        public Int32 compress_ops {get; set;}
        public Int32 compress_ops_ok {get; set;}
        public Int32 compress_time {get; set;}
        public Int32 uncompress_ops {get; set;}
        public Int32 uncompress_time {get; set;}
 }
}
