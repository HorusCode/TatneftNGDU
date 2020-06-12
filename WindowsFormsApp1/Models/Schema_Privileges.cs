using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***SCHEMA_PRIVILEGE MODEL***/
  [Table("SCHEMA_PRIVILEGES")]
 public partial class Schema_Privilege : IMicron
 {
        public String GRANTEE {get; set;}
        public String TABLE_CATALOG {get; set;}
        public String TABLE_SCHEMA {get; set;}
        public String PRIVILEGE_TYPE {get; set;}
        public String IS_GRANTABLE {get; set;}
 }
}
