using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***INNODB_METRIC MODEL***/
  [Table("INNODB_METRICS")]
 public partial class Innodb_Metric : IMicron
 {
        public String NAME {get; set;}
        public String SUBSYSTEM {get; set;}
        public Int64 COUNT {get; set;}
        public Int64 MAX_COUNT {get; set;}
        public Int64 MIN_COUNT {get; set;}
        public Double AVG_COUNT {get; set;}
        public Int64 COUNT_RESET {get; set;}
        public Int64 MAX_COUNT_RESET {get; set;}
        public Int64 MIN_COUNT_RESET {get; set;}
        public Double AVG_COUNT_RESET {get; set;}
        public DateTime TIME_ENABLED {get; set;}
        public DateTime TIME_DISABLED {get; set;}
        public Int64 TIME_ELAPSED {get; set;}
        public DateTime TIME_RESET {get; set;}
        public String STATUS {get; set;}
        public String TYPE {get; set;}
        public String COMMENT {get; set;}
 }
}
