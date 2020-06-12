using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***ROLE MODEL***/
  [Table("roles")]
 public partial class Role : IMicron
 {
        [Primary]
        public Int32 id {get; set;}
        public String name {get; set;}
 }
}
