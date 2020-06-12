using Micron;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Data.Models
{

#region CHARACTER_SETS
 public partial class Character_Set
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region COLLATIONS
 public partial class Collation
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region COLLATION_CHARACTER_SET_APPLICABILITY
 public partial class Collation_Character_Set_Applicability
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region COLUMNS
 public partial class Column
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region COLUMN_PRIVILEGES
 public partial class Column_Privilege
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region ENGINES
 public partial class Engine
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region EVENTS
 public partial class Event
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region FILES
 public partial class File
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region GLOBAL_STATUS
 public partial class Global_Status
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region GLOBAL_VARIABLES
 public partial class Global_Variable
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region KEY_COLUMN_USAGE
 public partial class Key_Column_Usage
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region OPTIMIZER_TRACE
 public partial class Optimizer_Trace
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region PARAMETERS
 public partial class Parameter
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region PARTITIONS
 public partial class Partition
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region PLUGINS
 public partial class Plugin
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region PROCESSLIST
 public partial class Processlist
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region PROFILING
 public partial class Profiling
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region REFERENTIAL_CONSTRAINTS
 public partial class Referential_Constraint
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region ROUTINES
 public partial class Routine
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region SCHEMATA
 public partial class Schema
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region SCHEMA_PRIVILEGES
 public partial class Schema_Privilege
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region SESSION_STATUS
 public partial class Session_Status
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region SESSION_VARIABLES
 public partial class Session_Variable
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region STATISTICS
 public partial class Statistic
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region TABLES
 public partial class Table
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region TABLESPACES
 public partial class Tablespace
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region TABLE_CONSTRAINTS
 public partial class Table_Constraint
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region TABLE_PRIVILEGES
 public partial class Table_Privilege
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region TRIGGERS
 public partial class Trigger
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region USER_PRIVILEGES
 public partial class User_Privilege
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region VIEWS
 public partial class View
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region INNODB_LOCKS
 public partial class Innodb_Lock
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region INNODB_TRX
 public partial class Innodb_Trx
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region INNODB_SYS_DATAFILES
 public partial class Innodb_Sys_Datafile
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region INNODB_LOCK_WAITS
 public partial class Innodb_Lock_Wait
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region INNODB_SYS_TABLESTATS
 public partial class Innodb_Sys_Tablestat
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region INNODB_CMP
 public partial class Innodb_Cmp
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region INNODB_METRICS
 public partial class Innodb_Metric
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region INNODB_CMP_RESET
 public partial class Innodb_Cmp_Reset
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region INNODB_CMP_PER_INDEX
 public partial class Innodb_Cmp_Per_Index
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region INNODB_CMPMEM_RESET
 public partial class Innodb_Cmpmem_Reset
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region INNODB_FT_DELETED
 public partial class Innodb_Ft_Deleted
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region INNODB_BUFFER_PAGE_LRU
 public partial class Innodb_Buffer_Page_Lru
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region INNODB_SYS_FOREIGN
 public partial class Innodb_Sys_Foreign
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region INNODB_SYS_COLUMNS
 public partial class Innodb_Sys_Column
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region INNODB_SYS_INDEXES
 public partial class Innodb_Sys_Index
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region INNODB_FT_DEFAULT_STOPWORD
 public partial class Innodb_Ft_Default_Stopword
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region INNODB_SYS_FIELDS
 public partial class Innodb_Sys_Field
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region INNODB_CMP_PER_INDEX_RESET
 public partial class Innodb_Cmp_Per_Index_Reset
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region INNODB_BUFFER_PAGE
 public partial class Innodb_Buffer_Page
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region INNODB_CMPMEM
 public partial class Innodb_Cmpmem
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region INNODB_FT_INDEX_TABLE
 public partial class Innodb_Ft_Index_Table
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region INNODB_FT_BEING_DELETED
 public partial class Innodb_Ft_Being_Deleted
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region INNODB_SYS_TABLESPACES
 public partial class Innodb_Sys_Tablespace
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region INNODB_FT_INDEX_CACHE
 public partial class Innodb_Ft_Index_Cache
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region INNODB_SYS_FOREIGN_COLS
 public partial class Innodb_Sys_Foreign_Col
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region INNODB_SYS_TABLES
 public partial class Innodb_Sys_Table
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region INNODB_BUFFER_POOL_STATS
 public partial class Innodb_Buffer_Pool_Stat
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion
#region INNODB_FT_CONFIG
 public partial class Innodb_Ft_Config
 {
public MicronDbContext DefaultDBContext { get; set; }


 }
#endregion

}
