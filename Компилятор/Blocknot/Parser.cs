using System;
using System.Text;

namespace Blocknot
{
    public static class Parser
    {
        public static string Parse(string analyzerOutput)
        {
            string[] lines = analyzerOutput.Split(new[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries);
            int errorCount = 0;
            StringBuilder result = new StringBuilder();

            foreach (string line in lines)
            {
                if (line.Contains("ERROR"))
                {
                    result.AppendLine("Ошибка: " + line);
                    errorCount++;
                }
            }

            if (errorCount == 0)
            {
                result.AppendLine("Ошибок не обнаружено.");
            }
            else
            {
                result.AppendLine();
                result.AppendLine("Обнаружено ошибок: " + errorCount);
            }

            return result.ToString();
        }
    }
}
