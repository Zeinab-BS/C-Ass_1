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




        }
    }
}
