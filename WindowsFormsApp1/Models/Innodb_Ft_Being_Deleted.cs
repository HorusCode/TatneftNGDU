using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***INNODB_FT_BEING_DELETED MODEL***/
  [Table("INNODB_FT_BEING_DELETED")]
 public partial class Innodb_Ft_Being_Deleted : IMicron
 {
        public UInt64 DOC_ID {get; set;}
 }
}
