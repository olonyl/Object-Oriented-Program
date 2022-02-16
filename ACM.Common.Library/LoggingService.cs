using ACM.Common.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace ACM.Common.Library
{
    public class LoggingService
    {
        public static void WriteToFile(List<ILoggable> changedItems)
        {
            // Set a variable to the Documents path.
            string docPath =
              Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter streamWriter = new StreamWriter(Path.Combine(docPath, "ACMLogging.txt"), true))
            {
                foreach (var item in changedItems)
                {
                    streamWriter.WriteLine(item.Log());

                }
            }
        }
    }
}
