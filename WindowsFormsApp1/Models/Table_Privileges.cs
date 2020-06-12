using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***TABLE_PRIVILEGE MODEL***/
  [Table("TABLE_PRIVILEGES")]
 public partial class Table_Privilege : IMicron
 {
        public String GRANTEE {get; set;}
        public String TABLE_CATALOG {get; set;}
        public String TABLE_SCHEMA {get; set;}
        public String TABLE_NAME {get; set;}
        public String PRIVILEGE_TYPE {get; set;}
        public String IS_GRANTABLE {get; set;}
 }
}
