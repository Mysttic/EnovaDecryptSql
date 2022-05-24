using EnovaDecryptSql.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EnovaDecryptSql
{
    public static class XMLParser
    {
        public static List<DatabaseCollectionMsSqlDatabase> Parse(string text)
        {
            DatabaseCollection collection = RawParsed<DatabaseCollection>(text);
            return collection.MsSqlDatabase.ToList();
        }

        static DatabaseCollection RawParsed<T>(string input) where T : DatabaseCollection
        {
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(T));
            string xml = System.IO.File.ReadAllText(input);
            using (StringReader sr = new StringReader(xml))
            {
                return (T)ser.Deserialize(sr);
            }
        }
    }
}
