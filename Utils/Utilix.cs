using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Markup;
using AppMultiTool.Utils.Controllers;

namespace AppMultiTool.Utils
{
    public static class Utilix
    {
        public static string SanitizeFileName(string fileName)
        {
            var invalidChars = Path.GetInvalidFileNameChars();
            return string.Concat(fileName.Select(c => invalidChars.Contains(c) ? '_' : c)).Replace("'",string.Empty);
        }

        public static bool IsNotNullOrEmptyOrWhiteSpace(string _str)
        {
            return !(string.IsNullOrEmpty(_str) && string.IsNullOrWhiteSpace(_str));
        }

        public static bool IsNullOrEmptyOrWhiteSpace(string _str)
        {
            return string.IsNullOrEmpty(_str) || string.IsNullOrWhiteSpace(_str);
        }

        public static int ConvertBoolToInt(bool _value)
        {
            return _value ? 1 : 0;
        }

        public static void HighlightSyntax(RichTextBox richTextBox, bool remove_highlight = false)
        {
            string[] reservedWords =
            {
                "ACCESSIBLE", "ADD", "ALL", "ALTER", "ANALYZE", "AND", "AS", "ASC", "ASENSITIVE", "BEFORE", "BETWEEN", "BIGINT", "BINARY", "BLOB", "BOTH", "BY", "CALL", "CASCADE", "CASE", "CHANGE", "CHAR", "CHARACTER", "CHECK", "CLOSE", "COLLATE", "COLUMN", "CONDITION", "CONSTRAINT", "CONTINUE", "CONVERT", "CREATE", "CROSS", "CURRENT_DATE", "CURRENT_TIME", "CURRENT_TIMESTAMP", "CURRENT_USER", "CURSOR", "DATABASE", "DATABASES", "DAY_HOUR", "DAY_MICROSECOND", "DAY_MINUTE", "DAY_SECOND", "DEC", "DECIMAL", "DECLARE", "DEFAULT", "DELAYED", "DELETE", "DESC", "DESCRIBE", "DETERMINISTIC", "DISTINCT", "DISTINCTROW", "DIV", "DOUBLE", "DROP", "DUAL", "EACH", "ELSE", "ELSEIF", "ENCLOSED", "END", "ESCAPED", "EXISTS", "EXIT", "EXPLAIN", "FALSE", "FETCH", "FLOAT", "FLOAT4", "FLOAT8", "FOR", "FORCE", "FOREIGN", "FROM", "FULLTEXT", "GENERATED", "GET", "GRANT", "GROUP", "HAVING", "HIGH_PRIORITY", "HOUR_MICROSECOND", "HOUR_MINUTE", "HOUR_SECOND", "IF", "IGNORE", "IN", "INDEX", "INFILE", "INNER", "INOUT", "INSENSITIVE", "INSERT", "INT", "INT1", "INT2", "INT3", "INT4", "INT8", "INTEGER", "INTERVAL", "INTO", "IO_AFTER_GTIDS", "IO_BEFORE_GTIDS", "IS", "ITERATE", "JOIN", "KEY", "KEYS", "KILL", "LEADING", "LEAVE", "LEFT", "LIKE", "LIMIT", "LINEAR", "LINES", "LOAD", "LOCALTIME", "LOCALTIMESTAMP", "LOCK", "LONG", "LONGBLOB", "LONGTEXT", "LOOP", "LOW_PRIORITY", "MASTER_BIND", "MASTER_SSL_VERIFY_SERVER_CERT", "MATCH", "MAXVALUE", "MEDIUMBLOB", "MEDIUMINT", "MEDIUMTEXT", "MIDDLEINT", "MINUTE_MICROSECOND", "MINUTE_SECOND", "MOD", "MODIFIES", "NATURAL", "NOT", "NO_WRITE_TO_BINLOG", "NULL", "NUMERIC", "ON", "OPEN", "OPTIMIZE", "OPTIMIZER_COSTS", "OPTION", "OPTIONALLY", "OR", "ORDER", "OUT", "OUTER", "OUTFILE", "PARTITION", "PRECISION", "PRIMARY", "PROCEDURE", "PURGE", "RANGE", "READ", "READS", "READ_WRITE", "REAL", "RECURSIVE", "REFERENCES", "REGEXP", "RELEASE", "RENAME", "REPEAT", "REPLACE", "REQUIRE", "RESIGNAL", "RESTRICT", "RETURN", "REVOKE", "RIGHT", "RLIKE", "SCHEMA", "SCHEMAS", "SECOND_MICROSECOND", "SELECT", "SENSITIVE", "SEPARATOR", "SET", "SHOW", "SIGNAL", "SMALLINT", "SPATIAL", "SPECIFIC", "SQL", "SQLEXCEPTION", "SQLSTATE", "SQLWARNING", "SQL_BIG_RESULT", "SQL_CALC_FOUND_ROWS", "SQL_SMALL_RESULT", "SSL", "STARTING", "STORED", "STRAIGHT_JOIN", "SYSTEM", "TABLE", "TERMINATED", "THEN", "TINYBLOB", "TINYINT", "TINYTEXT", "TO", "TRAILING", "TRIGGER", "TRUE", "UNDO", "UNION", "UNIQUE", "UNLOCK", "UNSIGNED", "UPDATE", "USAGE", "USE", "USING", "UTC_DATE", "UTC_TIME", "UTC_TIMESTAMP", "VALUES", "VALUE", "VARBINARY", "VARCHAR", "VARCHARACTER", "VARYING", "VIRTUAL", "WHEN", "WHERE", "WHILE", "WITH", "WRITE", "XOR", "YEAR_MONTH", "ZEROFILL", "START", "TRANSACTION", "COMMIT", "ROLLBACK", "SAVEPOINT", "ACTION", "AFTER", "AGAINST", "ALGORITHM", "ANY", "ARCHIVE", "ARRAY", "AUTOCOMMIT", "AUTOEXTEND_SIZE", "AUTO_INCREMENT", "AVG", "AVG_ROW_LENGTH", "BACKUP", "BEGIN", "BINLOG", "BIT", "BLOCK", "BOOL", "BOOLEAN", "BTREE", "BUCKETS", "BULK", "BYTE", "CACHE", "CASCADED", "CATALOG_NAME", "CHAIN", "CHANGED", "CHANNEL", "CHARSET", "CHECKPOINT", "CHECKSUM", "CIPHER", "CLASS_ORIGIN", "CLIENT", "CLONE", "CODE", "COLLATION", "COLUMN_FORMAT", "COLUMNS", "COLUMN_NAME", "COMMENT", "COMMITED", "COMPACT", "COMPRESSED", "COMPRESSION", "CONCURRENT", "CONNECTION", "CONSISTENT", "CONTAINS", "CONTEXT", "CONTRIBUTORS", "COPY", "CPU", "CUBE", "CURRENT", "CURRENT_ROLE", "CYCLE", "DATA", "DATAFILE", "DATETIME", "DAY", "DEALLOCATE", "DEFAULT_AUTH", "DEFINER", "DEFINITION", "DELAY_KEY_WRITE", "DES_KEY_FILE", "DIAGNOSTICS", "DIRECTORY", "DISABLE", "DISCARD", "DISK", "DO", "DUMP", "DUPLICATE", "DYNAMIC", "ENABLE", "ENCRYPTION", "ENDS", "ENGINE", "ENGINES", "ENUM", "ERROR", "ERRORS", "ESCAPE", "EVENT", "EVENTS", "EVERY", "EXCHANGE", "EXECUTE", "EXPIRE", "EXPRESSION", "EXPORT", "EXTENDED", "EXTENT_SIZE", "FAST", "FAULTS", "FIELDS", "FILE", "FILE_BLOCK_SIZE", "FILTER", "FINISH", "FIRST", "FIXED", "FLUSH", "FOLLOWS", "FORMAT", "FOUND", "FULL", "FUNCTION", "GENERAL", "GEOMETRY", "GEOMETRYCOLLECTION", "GET_FORMAT", "GLOBAL", "GRANTS", "GROUP_REPLICATION", "HANDLER", "HASH", "HELP", "HOST", "HOSTS", "HISTORY", "IDENTIFIED", "IGNORE_SERVER_IDS", "IMPORT", "INCREMENT", "INDEXES", "INITIAL_SIZE", "INSERT_METHOD", "INSTALL", "INSTANCE", "INVOKER", "IO_THREAD", "IPC", "ISOLATION", "ISSUER", "JSON", "KEY_BLOCK_SIZE", "KEY_ALGORITHM", "LANGUAGE", "LAST", "LEADER", "LINESTRING", "LIST", "LOCAL", "LOCATION", "LOCKS", "LOGFILE", "LOGS", "MASTER", "MASTER_AUTO_POSITION", "MASTER_CONNECT_RETRY", "MASTER_DELAY", "MASTER_HEARTBEAT_PERIOD", "MASTER_HOST", "MASTER_LOG_FILE", "MASTER_LOG_POS", "MASTER_PASSWORD", "MASTER_PORT", "MASTER_RETRY_COUNT", "MASTER_SERVER_ID", "MASTER_SSL", "MASTER_SSL_CA", "MASTER_SSL_CAPATH", "MASTER_SSL_CERT", "MASTER_SSL_CIPHER", "MASTER_SSL_CRL", "MASTER_SSL_CRLPATH", "MASTER_SSL_KEY", "MASTER_TLS_VERSION", "MASTER_USER", "MASTER_WAIT_POS", "MASTER_WAIT_TIMEOUT", "MASTER_WARNS", "MATERIALIZED", "MAX", "MAX_CONNECTIONS_PER_HOUR", "MAX_INDEX_LENGTH", "MAX_INSTANCES", "MAX_ROWS", "MAX_SIZE", "MAX_STATEMENT_TIME", "MAX_USER_CONNECTIONS", "MEMORY", "MERGE", "MESSAGE_TEXT", "MICROSECOND", "MIN", "MIN_ROWS", "MODE", "MODIFY", "MONTH", "MULTILINESTRING", "MULTIPOINT", "MULTIPOLYGON", "MUTEX", "MYSQL_ERRNO", "NAME", "NAMES", "NATIONAL", "NCHAR", "NDB", "NDBCLUSTER", "NESTED", "NEW", "NEXT", "NOCHECK", "NOWAIT", "NO_WAIT", "NUMBER", "NVARCHAR", "OF", "OFF", "OFFSET", "OIDS", "OLD_PASSWORD", "ONLY", "ORGANIZATION", "OTHER", "OWNER", "PACK_KEYS", "PAGE", "PARSE_GCOL_EXPR", "PARTIAL", "PASSWORD", "PHASE", "PLUGIN", "PLUGINS", "PLUGIN_DIR", "POINT", "POLYGON", "PORT", "PRECEDES", "PREPARE", "PRESERVE", "PREV", "PRIVILEGES", "PROCESS", "PROCESSLIST", "PROFILE", "PROFILES", "PROXY", "QUARTER", "QUERY", "QUICK", "READ_ONLY", "REBUILD", "RECOVER", "REDO_BUFFER_SIZE", "REDUNDANT", "REFERENCE", "RELAY", "RELAYLOG", "RELAY_LOG_FILE", "RELAY_LOG_POS", "RELAY_THREAD", "RELOAD", "REMOVE", "REORGANIZE", "REPAIR", "REPEATABLE", "REPLICATE_DO_DB", "REPLICATE_DO_TABLE", "REPLICATE_IGNORE_DB", "REPLICATE_IGNORE_TABLE", "REPLICATE_REWRITE_DB", "REPLICATE_WILD_DO_TABLE", "REPLICATE_WILD_IGNORE_TABLE", "REPLICATION", "REQUIRE_ROW_FORMAT", "RESET", "RESOURCE", "RESPECT", "RESTART", "RESTORE", "RESUME", "RETURNS", "REUSE", "ROLLUP", "ROUTINE", "ROW", "ROWS", "ROW_COUNT", "ROW_FORMAT", "SAVE", "SCHEDULE", "SCHEMA_NAME", "SECOND", "SECURITY", "SERIAL", "SERIALIZABLE", "SERVER", "SESSION", "SHARE", "SHARED", "SIGNAL", "SIGNED", "SIMPLE", "SLAVE", "SLOW", "SNAPSHOT", "SOCKET", "SOME", "SONAME", "SOUNDS", "SOURCE", "SQL_AFTER_GTIDS", "SQL_AFTER_MTS_GAPS", "SQL_BEFORE_GTIDS", "SQL_BUFFER_RESULT", "SQL_CACHE", "SQL_NO_CACHE", "SQL_THREAD", "SQL_TSI_DAY", "SQL_TSI_HOUR", "SQL_TSI_MINUTE", "SQL_TSI_MONTH", "SQL_TSI_QUARTER", "SQL_TSI_SECOND", "SQL_TSI_WEEK", "SQL_TSI_YEAR", "STACKED", "START", "STARTS", "STATS_AUTO_RECALC", "STATS_PERSISTENT", "STATS_SAMPLE_PAGES", "STATUS", "STOP", "STORAGE", "STRING", "SUBCLASS_ORIGIN", "SUBJECT", "SUBPARTITION", "SUBPARTITIONS", "SUPER", "SUSPEND", "SWAPS", "SWITCHES", "TABLESPACE", "TABLE_NAME", "TEMPORARY", "TEMPTABLE", "TEXT", "THAN", "THROWS", "TIES", "TIME", "TIMESTAMP", "TIMESTAMPADD", "TIMESTAMPDIFF", "TRANSACTIONAL", "TRIGGERS", "TRUNCATE", "TYPE", "TYPES", "UNBOUNDED", "UNCOMMITTED", "UNDEFINED", "UNDOFILE", "UNDO_BUFFER_SIZE", "UNICODE", "UNKNOWN", "UNTIL", "UPGRADE", "USER", "USER_RESOURCES", "USE_FRM", "VALIDATION", "VALUE", "VARIABLES", "VIEW", "WAIT", "WARNINGS", "WEEK", "WEIGHT_STRING", "WITHOUT", "WORK", "WRAPPER", "XID", "XML", "XPATH", "YEAR", "YES", "ZONE", "ANALYTIC", "CUME_DIST", "DENSE_RANK", "EMPTY", "EXCEPT", "FIRST_VALUE", "GROUPING", "GROUPS", "JSON_TABLE", "LAG", "LAST_VALUE", "LEAD", "NTH_VALUE", "NTILE", "OF", "OVER", "PERCENT_RANK", "RANK", "RECURSIVE", "ROW", "ROWS", "ROW_NUMBER", "SYSTEM", "WINDOW", "NOW"
            };            

            XMLHandler xml = new(CommonFile.AppSettings);
            bool usingDarkTheme = bool.Parse(xml.GetValueByAddKey(AppKeys.UseDarkTheme).Response);

            var textColor = usingDarkTheme ? Color.RoyalBlue : Color.Blue;
            var foreColorBase = usingDarkTheme ? Color.White : Color.Black;
            var fs = FontStyle.Bold;

            if (remove_highlight)
            {
                textColor = foreColorBase;
                fs = FontStyle.Regular;
            }

            richTextBox?.SuspendLayout();

            int cursorPosition = richTextBox.SelectionStart;
            int selectionLength = richTextBox.SelectionLength;

            richTextBox?.SelectAll();
            richTextBox.SelectionColor = foreColorBase;
            richTextBox.SelectionFont = new Font(richTextBox.Font, FontStyle.Regular);

            foreach (string keyword in reservedWords)
            {
                string pattern = $@"\b{keyword}\b";

                var matchList = MatchList.ConvertBy(Regex.Matches(richTextBox.Text, pattern, RegexOptions.IgnoreCase));
                matchList.ForEach(match =>
                {
                    richTextBox?.Select(match.Index, match.Length);
                    richTextBox.SelectionColor = textColor;
                    richTextBox.SelectionFont = new Font(richTextBox.Font, fs);
                });
            }

            richTextBox?.Select(cursorPosition, selectionLength);

            richTextBox?.ResumeLayout();
        }

        public static void HighlightSyntax(TextBox txt) => throw new Exception("O método HighlightSyntax só funciona com RichTextBox");

        public static void EnableControlColor<T>(T control, bool canChangeForeColor = true, string newTxt = "") where T : Control
        {
            control.Enabled = true;
            control.ForeColor = canChangeForeColor ? Color.White : control.ForeColor;
            control.Text = newTxt != string.Empty ? newTxt : control.Text;
        }

        public static void DisableControlColor<T>(T control, bool canChangeForeColor = true, string newTxt = "") where T : Control
        {
            XMLHandler xml = new(CommonFile.AppSettings);
            bool usingDarkTheme = bool.Parse(xml.GetValueByAddKey(AppKeys.UseDarkTheme).Response);
            var disableColor = usingDarkTheme ? Color.Red : Color.Black;

            control.Enabled = false;
            control.ForeColor = canChangeForeColor ? disableColor : control.ForeColor;
            control.Text = newTxt != string.Empty ? newTxt : control.Text;
        }

        public static bool TextContains(string text, string value) => text.Contains(value, StringComparison.CurrentCultureIgnoreCase);
    }
}
