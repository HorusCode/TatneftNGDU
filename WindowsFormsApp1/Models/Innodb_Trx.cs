using Micron;
using System;
using System.Collections.Generic;

namespace Data.Models
{
/***INNODB_TRX MODEL***/
  [Table("INNODB_TRX")]
 public partial class Innodb_Trx : IMicron
 {
        public String trx_id {get; set;}
        public String trx_state {get; set;}
        public DateTime trx_started {get; set;}
        public String trx_requested_lock_id {get; set;}
        public DateTime trx_wait_started {get; set;}
        public UInt64 trx_weight {get; set;}
        public UInt64 trx_mysql_thread_id {get; set;}
        public String trx_query {get; set;}
        public String trx_operation_state {get; set;}
        public UInt64 trx_tables_in_use {get; set;}
        public UInt64 trx_tables_locked {get; set;}
        public UInt64 trx_lock_structs {get; set;}
        public UInt64 trx_lock_memory_bytes {get; set;}
        public UInt64 trx_rows_locked {get; set;}
        public UInt64 trx_rows_modified {get; set;}
        public UInt64 trx_concurrency_tickets {get; set;}
        public String trx_isolation_level {get; set;}
        public Int32 trx_unique_checks {get; set;}
        public Int32 trx_foreign_key_checks {get; set;}
        public String trx_last_foreign_key_error {get; set;}
        public Int32 trx_adaptive_hash_latched {get; set;}
        public UInt64 trx_adaptive_hash_timeout {get; set;}
        public Int32 trx_is_read_only {get; set;}
        public Int32 trx_autocommit_non_locking {get; set;}
 }
}
