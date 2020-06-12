using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***VIEW MODEL***/
  [Table("VIEWS")]
 public partial class View : IMicron
 {
        public String TABLE_CATALOG {get; set;}
        public String TABLE_SCHEMA {get; set;}
        public String TABLE_NAME {get; set;}
        public String VIEW_DEFINITION {get; set;}
        public String CHECK_OPTION {get; set;}
        public String IS_UPDATABLE {get; set;}
        public String DEFINER {get; set;}
        public String SECURITY_TYPE {get; set;}
        public String CHARACTER_SET_CLIENT {get; set;}
        public String COLLATION_CONNECTION {get; set;}
 }
}
