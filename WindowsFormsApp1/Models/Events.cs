using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***EVENT MODEL***/
  [Table("EVENTS")]
 public partial class Event : IMicron
 {
        public String EVENT_CATALOG {get; set;}
        public String EVENT_SCHEMA {get; set;}
        public String EVENT_NAME {get; set;}
        public String DEFINER {get; set;}
        public String TIME_ZONE {get; set;}
        public String EVENT_BODY {get; set;}
        public String EVENT_DEFINITION {get; set;}
        public String EVENT_TYPE {get; set;}
        public DateTime EXECUTE_AT {get; set;}
        public String INTERVAL_VALUE {get; set;}
        public String INTERVAL_FIELD {get; set;}
        public String SQL_MODE {get; set;}
        public DateTime STARTS {get; set;}
        public DateTime ENDS {get; set;}
        public String STATUS {get; set;}
        public String ON_COMPLETION {get; set;}
        public DateTime CREATED {get; set;}
        public DateTime LAST_ALTERED {get; set;}
        public DateTime LAST_EXECUTED {get; set;}
        public String EVENT_COMMENT {get; set;}
        public Int64 ORIGINATOR {get; set;}
        public String CHARACTER_SET_CLIENT {get; set;}
        public String COLLATION_CONNECTION {get; set;}
        public String DATABASE_COLLATION {get; set;}
 }
}
