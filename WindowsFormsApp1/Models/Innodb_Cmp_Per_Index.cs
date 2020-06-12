using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***INNODB_CMP_PER_INDEX MODEL***/
  [Table("INNODB_CMP_PER_INDEX")]
 public partial class Innodb_Cmp_Per_Index : IMicron
 {
        public String database_name {get; set;}
        public String table_name {get; set;}
        public String index_name {get; set;}
        public Int32 compress_ops {get; set;}
        public Int32 compress_ops_ok {get; set;}
        public Int32 compress_time {get; set;}
        public Int32 uncompress_ops {get; set;}
        public Int32 uncompress_time {get; set;}
 }
}
