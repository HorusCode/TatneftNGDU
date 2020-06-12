using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***INNODB_LOCK_WAIT MODEL***/
  [Table("INNODB_LOCK_WAITS")]
 public partial class Innodb_Lock_Wait : IMicron
 {
        public String requesting_trx_id {get; set;}
        public String requested_lock_id {get; set;}
        public String blocking_trx_id {get; set;}
        public String blocking_lock_id {get; set;}
 }
}
