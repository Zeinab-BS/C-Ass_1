using System.Drawing;

namespace C_Ass_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question1
            /*
            Create a Book class with a Title (string) and Pages (int). 
            Create a Book object and store it in a variable of type object. Print it. 
           */

            //Book book = new Book();
            //book.Title = "Programming";
            //book.Pages = 200;
            //object obj = book;
            //Console.WriteLine(obj.ToString());
            #endregion

            #region Question2
            /*
            Using the Book class above, print the result of calling ToString(), 
            Equals() (compare book with itself),
            GetHashCode(), and GetType() on book
            */

            //Book book = new Book();
            //Console.WriteLine(book.ToString());//C_Ass_1.Book
            //Console.WriteLine(book.Equals(book));//true
            //Console.WriteLine(book.GetHashCode());//address
            //Console.WriteLine(book.GetType());//C_Ass_1.Book
            #endregion


            #region Question3

            /*
            Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
            int pages = "464"; 
            */
            // this is a compile time error 
            // correction :int pages = 464;

            #endregion

            #region Question4
            //int y = 0;
            //try
            //{
            //    int x = 10 /y;
            //}

            //catch 
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}

            //finally
            //{
            //    Console.WriteLine("Done");

            //}

            #endregion

            #region Question5
            // Declare an int pages = 300; then store it in a double variable without using a cast.
            //int pages = 300;
            //double DoublePages = pages;//implict casting
            //Console.WriteLine(DoublePages);

            #endregion

            #region Question6
            /*
            Declare a double price = 49.99; then convert it into an int using a cast.
            */
            //double price = 49.99;
            //int IntPrice = (int)price;// double ->int (explict casting) / (unsafe =loss data)
            //Console.WriteLine(IntPrice);
            #endregion

            #region Question7
            //Given string pagesText = "464";, convert it into an int using the Convert class.
            //string pagesText = "464";
            //int pagesInt = Convert.ToInt32(pagesText);
            //Console.WriteLine(pagesInt);
            #endregion

            #region Question8
            /*
             Given string yearText = "2023";, convert it using int.Parse(). 
             Then given string badText = "abc";, use int.TryParse() to safely try converting it,
             and print "Invalid number" if it fails.
            */
            //string yearText = "2023";
            //int yearInt=int.Parse(yearText);
            //Console.WriteLine(yearInt);

            //string badText = "abc";
            //bool flag = int.TryParse(badText, out int res);
            //if (flag == false)
            //{
            //    Console.WriteLine("Invalid number");
            //}
            //else
            //{
            //    Console.WriteLine(res);
            //}
            #endregion

            #region Question9
            /*
            Given int pages = 464;, convert it into a string using ToString()
            and print its type using GetType() to prove it's now a string.
            */
            //int pages = 464;
            //string StringPages=pages.ToString();
            //Console.WriteLine(StringPages);
            //Console.WriteLine(StringPages.GetType());//system.string
            #endregion

            #region Question10
            /*
             Declare int copies = 100;. Box it into an object variable,
             then unbox it back into a new int variable, and print both.
            */
            //int copies = 100;
            //object obj = copies;//implict (boxing)
            //Console.WriteLine("Boxing:"+obj);

            //int newCopy = (int)obj; // explict (unboxing)
            //Console.WriteLine("unBoxing:"+ newCopy);

            #endregion

            #region Question11

            /*
             Declare an int? year = null;. Print whether it has a value, 
            then assign it 2023 and print its value.
            */

            //int? year = null;
            //Console.WriteLine(year.HasValue);
            //year = 2023;
            //Console.WriteLine(year.Value);



            #endregion


            #region Question12

            /*Declare a string? reviewer = null;. Print whether it is null.*/

            //string?reviewer=null;
            //Console.WriteLine(reviewer is null);

            #endregion







        }
    }
}
