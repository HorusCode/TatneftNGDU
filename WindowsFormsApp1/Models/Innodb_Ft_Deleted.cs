using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***INNODB_FT_DELETED MODEL***/
  [Table("INNODB_FT_DELETED")]
 public partial class Innodb_Ft_Deleted : IMicron
 {
        public UInt64 DOC_ID {get; set;}
 }
}
