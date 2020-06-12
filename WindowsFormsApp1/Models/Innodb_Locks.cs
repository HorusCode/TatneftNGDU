using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***INNODB_LOCK MODEL***/
  [Table("INNODB_LOCKS")]
 public partial class Innodb_Lock : IMicron
 {
        public String lock_id {get; set;}
        public String lock_trx_id {get; set;}
        public String lock_mode {get; set;}
        public String lock_type {get; set;}
        public String lock_table {get; set;}
        public String lock_index {get; set;}
        public UInt64 lock_space {get; set;}
        public UInt64 lock_page {get; set;}
        public UInt64 lock_rec {get; set;}
        public String lock_data {get; set;}
 }
}
