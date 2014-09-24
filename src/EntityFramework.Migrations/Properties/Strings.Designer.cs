// <auto-generated />
namespace Microsoft.Data.Entity.Migrations
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Strings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("EntityFramework.Migrations.Strings", typeof(Strings).GetTypeInfo().Assembly);

        /// <summary>
        /// The string argument '{argumentName}' cannot be empty.
        /// </summary>
        internal static string ArgumentIsEmpty
        {
            get { return GetString("ArgumentIsEmpty"); }
        }

        /// <summary>
        /// The string argument '{argumentName}' cannot be empty.
        /// </summary>
        internal static string FormatArgumentIsEmpty(object argumentName)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ArgumentIsEmpty", "argumentName"), argumentName);
        }

        /// <summary>
        /// The value provided for argument '{argumentName}' must be a valid value of enum type '{enumType}'.
        /// </summary>
        internal static string InvalidEnumValue
        {
            get { return GetString("InvalidEnumValue"); }
        }

        /// <summary>
        /// The value provided for argument '{argumentName}' must be a valid value of enum type '{enumType}'.
        /// </summary>
        internal static string FormatInvalidEnumValue(object argumentName, object enumType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("InvalidEnumValue", "argumentName", "enumType"), argumentName, enumType);
        }

        /// <summary>
        /// The current migration SQL generator '{sqlGeneratorType}' is unable to generate SQL for operations of type '{operationType}'.
        /// </summary>
        internal static string UnknownOperation
        {
            get { return GetString("UnknownOperation"); }
        }

        /// <summary>
        /// The current migration SQL generator '{sqlGeneratorType}' is unable to generate SQL for operations of type '{operationType}'.
        /// </summary>
        internal static string FormatUnknownOperation(object sqlGeneratorType, object operationType)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("UnknownOperation", "sqlGeneratorType", "operationType"), sqlGeneratorType, operationType);
        }

        /// <summary>
        /// The target migration '{targetMigrationName}' was not found.
        /// </summary>
        internal static string TargetMigrationNotFound
        {
            get { return GetString("TargetMigrationNotFound"); }
        }

        /// <summary>
        /// The target migration '{targetMigrationName}' was not found.
        /// </summary>
        internal static string FormatTargetMigrationNotFound(object targetMigrationName)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("TargetMigrationNotFound", "targetMigrationName"), targetMigrationName);
        }

        /// <summary>
        /// The history repository includes a migration with the identifier '{migrationId}' but the migration assembly does not contain the corresponding migration class.
        /// </summary>
        internal static string LocalMigrationNotFound
        {
            get { return GetString("LocalMigrationNotFound"); }
        }

        /// <summary>
        /// The history repository includes a migration with the identifier '{migrationId}' but the migration assembly does not contain the corresponding migration class.
        /// </summary>
        internal static string FormatLocalMigrationNotFound(object migrationId)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("LocalMigrationNotFound", "migrationId"), migrationId);
        }

        /// <summary>
        /// '{migrationId}' is not a valid migration identifier.
        /// </summary>
        internal static string InvalidMigrationId
        {
            get { return GetString("InvalidMigrationId"); }
        }

        /// <summary>
        /// '{migrationId}' is not a valid migration identifier.
        /// </summary>
        internal static string FormatInvalidMigrationId(object migrationId)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("InvalidMigrationId", "migrationId"), migrationId);
        }

        /// <summary>
        /// Creating migration history table.
        /// </summary>
        internal static string MigratorLoggerCreatingHistoryTable
        {
            get { return GetString("MigratorLoggerCreatingHistoryTable"); }
        }

        /// <summary>
        /// Creating migration history table.
        /// </summary>
        internal static string FormatMigratorLoggerCreatingHistoryTable()
        {
            return GetString("MigratorLoggerCreatingHistoryTable");
        }

        /// <summary>
        /// Dropping migration history table.
        /// </summary>
        internal static string MigratorLoggerDroppingHistoryTable
        {
            get { return GetString("MigratorLoggerDroppingHistoryTable"); }
        }

        /// <summary>
        /// Dropping migration history table.
        /// </summary>
        internal static string FormatMigratorLoggerDroppingHistoryTable()
        {
            return GetString("MigratorLoggerDroppingHistoryTable");
        }

        /// <summary>
        /// Applying migration '{migrationId}'.
        /// </summary>
        internal static string MigratorLoggerApplyingMigration
        {
            get { return GetString("MigratorLoggerApplyingMigration"); }
        }

        /// <summary>
        /// Applying migration '{migrationId}'.
        /// </summary>
        internal static string FormatMigratorLoggerApplyingMigration(object migrationId)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("MigratorLoggerApplyingMigration", "migrationId"), migrationId);
        }

        /// <summary>
        /// Reverting migration '{migrationId}'.
        /// </summary>
        internal static string MigratorLoggerRevertingMigration
        {
            get { return GetString("MigratorLoggerRevertingMigration"); }
        }

        /// <summary>
        /// Reverting migration '{migrationId}'.
        /// </summary>
        internal static string FormatMigratorLoggerRevertingMigration(object migrationId)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("MigratorLoggerRevertingMigration", "migrationId"), migrationId);
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
