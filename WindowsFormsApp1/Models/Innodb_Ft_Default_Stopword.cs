using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***INNODB_FT_DEFAULT_STOPWORD MODEL***/
  [Table("INNODB_FT_DEFAULT_STOPWORD")]
 public partial class Innodb_Ft_Default_Stopword : IMicron
 {
        public String value {get; set;}
 }
}
