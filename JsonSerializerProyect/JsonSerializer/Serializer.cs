using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSerializer
{
    public class Serializer
    {
        public static readonly string FielSeparetor = ",";
        public static readonly string BeginJason = "{";
        public static readonly string FinishJason = "}";
        public static readonly string BeginArray = "[";
        public static readonly string FinishArray = "]";
        public static readonly string StringQuote = "\"";
        public static readonly string PairSeparator = ":";
        public static readonly string NullSymbol = "null";

        public string Serialize(object classObj)
        {
            if (classObj == null) return NullSymbol;
            if (classObj is string) return SerializerToString(classObj);

            return "";

        }
        public static string SerializerToString(object classObj)
        {
            StringBuilder String = new StringBuilder(StringQuote);
            String.Append(classObj).Append(StringQuote);

            return String.ToString();
        }

    }
}