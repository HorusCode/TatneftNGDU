using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***COLUMN_PRIVILEGE MODEL***/
  [Table("COLUMN_PRIVILEGES")]
 public partial class Column_Privilege : IMicron
 {
        public String GRANTEE {get; set;}
        public String TABLE_CATALOG {get; set;}
        public String TABLE_SCHEMA {get; set;}
        public String TABLE_NAME {get; set;}
        public String COLUMN_NAME {get; set;}
        public String PRIVILEGE_TYPE {get; set;}
        public String IS_GRANTABLE {get; set;}
 }
}
