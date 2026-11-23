namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.pages = 200;
            book.title = "great Expectation";

            Object obj = book;
            Console.WriteLine(obj);

            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());
            //int pages = "464"; its a compile erro because pages integar and here we put this value in ""


            try
            {
                int result = 10 / 0;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }



            int pages = 300;
            double pag = pages;
            Console.WriteLine(pag);

            double price = 49.99;
            int pric =(int) price;//like un boxing
            Console.WriteLine(pric);

            String text = "464";
            int page=Convert.ToInt32(text);
            Console.WriteLine(page);


            String yearText = "2023";
            int year = int.Parse(yearText);
            Console.WriteLine(year);

            String badtext = "abc";
            bool success = int.TryParse(badtext, out int number);

            if (success)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
            int Pages = 464;
            string page_text = Convert.ToString(Pages);
            Console.WriteLine(page_text.GetType);


            int x = 1000;
            object ob = x;
            int y = (int)ob;
            Console.WriteLine(y);
        }   
    }
}
    

