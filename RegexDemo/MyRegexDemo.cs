using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
namespace RegexDemo
{
    public class MyRegexDemo
    {
        public static void RegexMain()
        {
            string jsonText = @"{""input"" : ""value"", ""output"" : ""result""}";
            JsonReader jrd = new JsonTextReader(new StringReader(jsonText));
            while(jrd.Read()){
                Type tmep_type=jrd.ValueType;
               
                string temp_str=Convert.ToString(jrd.Value);
                Console.WriteLine(temp_str);
            }
            string regStr = @"\b" +
                            @"(?'letter'\w)" +
                            @"\w+" +
                            @"\k'letter'" +
                            @"\b";
            foreach (Match m in Regex.Matches("bob pope peep wow hoh", regStr))
                Console.WriteLine(m + " ");
        }
    }
}
