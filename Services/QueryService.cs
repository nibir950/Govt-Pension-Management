using System;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace Govt.BDPension.Services
{
    public static class QueryService
    {
        private static XDocument _queriesDoc;
        private static string _queriesFilePath;

        static QueryService()
        {
            _queriesFilePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Data",
                "SqlQueries.xml");
            LoadQueries();
        }

        private static void LoadQueries()
        {
            try
            {
                if (File.Exists(_queriesFilePath))
                {
                    _queriesDoc = XDocument.Load(_queriesFilePath);
                }
                else
                {
                    throw new FileNotFoundException($"SQL queries file not found at: {_queriesFilePath}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to load SQL queries: {ex.Message}", ex);
            }
        }

        public static string GetQuery(string category, string queryName, params object[] parameters)
        {
            try
            {
                if (_queriesDoc == null)
                {
                    LoadQueries();
                }

                XElement categoryElement = _queriesDoc.Root?.Element(category);
                if (categoryElement == null)
                {
                    throw new Exception($"Category '{category}' not found in queries file.");
                }

                XElement queryElement = categoryElement.Element(queryName);
                if (queryElement == null)
                {
                    throw new Exception($"Query '{queryName}' not found in category '{category}'.");
                }

                string query = queryElement.Value;

                if (parameters != null && parameters.Length > 0)
                {
                    return string.Format(query, parameters);
                }

                return query;
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to get query '{category}.{queryName}': {ex.Message}", ex);
            }
        }

        public static void ReloadQueries()
        {
            LoadQueries();
        }
    }
}

