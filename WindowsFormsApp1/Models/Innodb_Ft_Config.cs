using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***INNODB_FT_CONFIG MODEL***/
  [Table("INNODB_FT_CONFIG")]
 public partial class Innodb_Ft_Config : IMicron
 {
        public String KEY {get; set;}
        public String VALUE {get; set;}
 }
}
