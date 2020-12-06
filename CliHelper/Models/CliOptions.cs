namespace CliHelper.Models
{
    /// <summary>
    /// A options object to use in the <see cref="CliApplication"/>.
    /// </summary>
    public class CliOptions
    {
        /// <summary>
        /// Gets a value indicating whether show the stack trace on throws a exception.
        /// If false console write the exception message only.
        /// </summary>
        internal bool ShowStackTraceOnError { get; }

        /// <summary>
        /// Gets a value indicating whether it contains the default --help command.
        /// </summary>
        ///
        internal bool AddHelp { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CliOptions"/> class.
        /// The CLI Application options.
        /// </summary>
        /// <param name="showStackTraceOnError">
        /// Show the stack trace if throws exception.
        /// If false console write the exception message only.
        /// </param>
        /// <param name="addHelp">Add the --help command.</param>
        public CliOptions(bool showStackTraceOnError = false, bool addHelp = true)
        {
            ShowStackTraceOnError = showStackTraceOnError;
            AddHelp = addHelp;
        }
    }
}