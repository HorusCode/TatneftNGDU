using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***PROCESSLIST MODEL***/
  [Table("PROCESSLIST")]
 public partial class Processlist : IMicron
 {
        public UInt64 ID {get; set;}
        public String USER {get; set;}
        public String HOST {get; set;}
        public String DB {get; set;}
        public String COMMAND {get; set;}
        public Int32 TIME {get; set;}
        public String STATE {get; set;}
        public String INFO {get; set;}
 }
}
