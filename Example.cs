using System;

namespace TipleByte_Email_Question
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // The folowing code was sent to me by triplebyte and I just had to solve it.
            // really it was not hard I just noticed something that caught my eye.


            int i;
            for (i =0; i < 10; i++)
            {
                //Do something
            }
            int x = i;
            Console.WriteLine("i is equal to: " + i.ToString());
            Console.Read();
            // so as we see above we have the variable int i.
            // Within our for loop i will continue to increase until i < 10 is complete. 
            // At the end we have a new variable x which will contain i after the for loop has been completed.
            // The value of i is 9, because 9 < 10 = true. 
            // One of the multiple choice selections is 10, but 10 < 10 = true. Lets see if im right I was wrong to think
            // That the iteriration stopped at 9. Well now I know!
        }
    }
}
