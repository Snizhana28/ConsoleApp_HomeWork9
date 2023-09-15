using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_HomeWork9.Domain
{
    public class Magazine
    {
        /*Створіть користувацький тип «Журнал», який зберігатиме таку 
                    інформацію:
                     Назва журналу.
                     Жанр.
                     Кількість сторінок у випуску.
                     Дата видання*/
        public string Name { get; set; }
        public string Genre { get; set; }
        public int NumberOfPages { get; set; }
        public DateTime DateOfPublication { get; set; }
        public int PageNumber { get; set; }
        public Magazine() { }
        public Magazine(string name, string genre, int numberOfPages, DateTime dateOfPublication)
        {
            Name = name;
            Genre = genre;
            NumberOfPages = numberOfPages;
            DateOfPublication = dateOfPublication;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Genre: {Genre}, Number of pages: {NumberOfPages}, Date of publication: {DateOfPublication}";
        }
    }
}
