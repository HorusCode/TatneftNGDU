using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***TRIGGER MODEL***/
  [Table("TRIGGERS")]
 public partial class Trigger : IMicron
 {
        public String TRIGGER_CATALOG {get; set;}
        public String TRIGGER_SCHEMA {get; set;}
        public String TRIGGER_NAME {get; set;}
        public String EVENT_MANIPULATION {get; set;}
        public String EVENT_OBJECT_CATALOG {get; set;}
        public String EVENT_OBJECT_SCHEMA {get; set;}
        public String EVENT_OBJECT_TABLE {get; set;}
        public Int64 ACTION_ORDER {get; set;}
        public String ACTION_CONDITION {get; set;}
        public String ACTION_STATEMENT {get; set;}
        public String ACTION_ORIENTATION {get; set;}
        public String ACTION_TIMING {get; set;}
        public String ACTION_REFERENCE_OLD_TABLE {get; set;}
        public String ACTION_REFERENCE_NEW_TABLE {get; set;}
        public String ACTION_REFERENCE_OLD_ROW {get; set;}
        public String ACTION_REFERENCE_NEW_ROW {get; set;}
        public DateTime CREATED {get; set;}
        public String SQL_MODE {get; set;}
        public String DEFINER {get; set;}
        public String CHARACTER_SET_CLIENT {get; set;}
        public String COLLATION_CONNECTION {get; set;}
        public String DATABASE_COLLATION {get; set;}
 }
}
