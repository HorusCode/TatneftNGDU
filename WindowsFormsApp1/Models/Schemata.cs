using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***SCHEMA MODEL***/
  [Table("SCHEMATA")]
 public partial class Schema : IMicron
 {
        public String CATALOG_NAME {get; set;}
        public String SCHEMA_NAME {get; set;}
        public String DEFAULT_CHARACTER_SET_NAME {get; set;}
        public String DEFAULT_COLLATION_NAME {get; set;}
        public String SQL_PATH {get; set;}
 }
}
