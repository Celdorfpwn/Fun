using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Find a 9 letter string of characters that contains only letters from
//acdegilmnoprstuw
//such that the hash(the_string) is
//914117715920704
//if hash is defined by the following pseudo-code:
//Int64 hash(String s)
//{
//    Int64 h = 7
//    String letters = "acdegilmnoprstuw"
//    for (Int32 i = 0; i < s.length; i++)
//    {
//        h = (h * 37 + letters.indexOf(s[i]))
//    }
//    return h
//}
//For example, if we were trying to find the 7 letter string where hash(the_string) was 680131659347, the answer would be "leepadg".



namespace TrelloHashAlgorithmSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            var decode = new StringBuilder().Decode(914117715920704).ToString();
            var decodeRecursive = DecodeRecursive(914117715920704);
            Console.WriteLine(decode);
            Console.WriteLine(decodeRecursive);
            Console.ReadKey();
        }

        // RECURSIVE
        public static string DecodeRecursive(Int64 hash)
        {
            return hash > 7 ? (DecodeRecursive(hash / 37) + ("acdegilmnoprstuw").ElementAt(Convert.ToInt32(hash % 37))) : String.Empty;
        }
    }

    // USING EXTENSION
    internal static class Extensions
    {
        public static StringBuilder Decode(this StringBuilder builder, Int64 hash)
        {
            return hash > 7 ? builder.Decode(hash / 37).Append(("acdegilmnoprstuw").ElementAt(Convert.ToInt32(hash % 37))) : builder;
        }
    }
}
