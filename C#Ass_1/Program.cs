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




        }
    }
}
