using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Text;

namespace Assinment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print
            //both title and upperTitle to show that title did not change.
            //string title = "clean code";
            //string upperTitle = title.ToUpper();
            //Console.WriteLine(title);
            //Console.WriteLine(upperTitle);//CLEAN CODE
            #endregion

            #region Q02
            //Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()
            //to check if they point to the same object in memory.
            //string literal1 = "Clean Code";
            //string literal2 = "Clean Code";
            //Console.WriteLine(ReferenceEquals(literal1, literal2));//the same literal then they point to the same reference
            #endregion

            #region Q03
            //Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
            //object.Print the final result.
            //StringBuilder sb = new StringBuilder();
            //sb.Append("Book List");
            //sb.Append(" - Updated");
            //Console.WriteLine(sb.ToString());
            #endregion

            #region Q04
            //Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
            //Print the result.
            //sb.Replace("Book List", "Library");
            //Console.WriteLine(sb.ToString());
            #endregion

            #region Q05
            //Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code,
            //Pages: 464" using the + operator.
            string title = "Clean Code";
            int pages = 464;
            Console.WriteLine("Book: " + title + ",Pages: " + pages);
            #endregion
        }
    }
}
