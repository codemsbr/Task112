using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Library
    {
        Book[] myArray = new Book[0];
        public void AddBook(Book book)
        {
            Array.Resize(ref myArray, myArray.Length + 1);
            myArray[myArray.Length - 1] = book;
        }

        public void GetBookById(int id)
        {
            int indexOf = Index(id);
            if (indexOf != -1)
            {
                Console.WriteLine(myArray[indexOf]);
            }
        }

        int Index(int Id)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i].Id == Id)
                    return i;
            }
            return -1;
        }
    }
}
