using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***ROUTINE MODEL***/
  [Table("ROUTINES")]
 public partial class Routine : IMicron
 {
        public String SPECIFIC_NAME {get; set;}
        public String ROUTINE_CATALOG {get; set;}
        public String ROUTINE_SCHEMA {get; set;}
        public String ROUTINE_NAME {get; set;}
        public String ROUTINE_TYPE {get; set;}
        public String DATA_TYPE {get; set;}
        public Int32 CHARACTER_MAXIMUM_LENGTH {get; set;}
        public Int32 CHARACTER_OCTET_LENGTH {get; set;}
        public UInt64 NUMERIC_PRECISION {get; set;}
        public Int32 NUMERIC_SCALE {get; set;}
        public UInt64 DATETIME_PRECISION {get; set;}
        public String CHARACTER_SET_NAME {get; set;}
        public String COLLATION_NAME {get; set;}
        public String DTD_IDENTIFIER {get; set;}
        public String ROUTINE_BODY {get; set;}
        public String ROUTINE_DEFINITION {get; set;}
        public String EXTERNAL_NAME {get; set;}
        public String EXTERNAL_LANGUAGE {get; set;}
        public String PARAMETER_STYLE {get; set;}
        public String IS_DETERMINISTIC {get; set;}
        public String SQL_DATA_ACCESS {get; set;}
        public String SQL_PATH {get; set;}
        public String SECURITY_TYPE {get; set;}
        public DateTime CREATED {get; set;}
        public DateTime LAST_ALTERED {get; set;}
        public String SQL_MODE {get; set;}
        public String ROUTINE_COMMENT {get; set;}
        public String DEFINER {get; set;}
        public String CHARACTER_SET_CLIENT {get; set;}
        public String COLLATION_CONNECTION {get; set;}
        public String DATABASE_COLLATION {get; set;}
 }
}
