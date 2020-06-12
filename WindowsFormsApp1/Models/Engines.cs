using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***ENGINE MODEL***/
  [Table("ENGINES")]
 public partial class Engine : IMicron
 {
        public String ENGINE {get; set;}
        public String SUPPORT {get; set;}
        public String COMMENT {get; set;}
        public String TRANSACTIONS {get; set;}
        public String XA {get; set;}
        public String SAVEPOINTS {get; set;}
 }
}
