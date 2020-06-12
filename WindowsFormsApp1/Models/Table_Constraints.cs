using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***TABLE_CONSTRAINT MODEL***/
  [Table("TABLE_CONSTRAINTS")]
 public partial class Table_Constraint : IMicron
 {
        public String CONSTRAINT_CATALOG {get; set;}
        public String CONSTRAINT_SCHEMA {get; set;}
        public String CONSTRAINT_NAME {get; set;}
        public String TABLE_SCHEMA {get; set;}
        public String TABLE_NAME {get; set;}
        public String CONSTRAINT_TYPE {get; set;}
 }
}
