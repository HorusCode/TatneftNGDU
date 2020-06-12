using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***FIRE MODEL***/
  [Table("fires")]
 public partial class Fire : IMicron
 {
        [Primary]
        public Int32 id {get; set;}
        [Foreign(typeof(User))]
        public Int32 user_id {get; set;}
        public SByte status {get; set;}
        public DateTime created_at {get; set;}
        public DateTime updated_at {get; set;}
 }
}
