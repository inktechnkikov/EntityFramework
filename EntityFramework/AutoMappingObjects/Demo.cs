using AutoMapper;
using AutoMappingObjects.DTOs;
using AutoMappingObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMappingObjects
{
    class Demo
    {
        static void Main(string[] args)
        {
            MappingContext context = new MappingContext();

            Author author = new Author()
            {
                Name = "Hans"
            };
            Book book = new Book()
            {
                Author = author,
                Title = "Red Riding"
            };

            BookDto dto = new BookDto()
            {
                Title = book.Title,
                AuthorId = book.AuthorId
            };
            context.Books.Add(book);
            context.SaveChanges();
            //Console.WriteLine(dto.Title);
            //Console.WriteLine(dto.AuthorId);
            ConfigureAutomapper();
            BookDto dtoMap = Mapper.Map<BookDto>(book);
            Console.WriteLine(dtoMap.Title);
            Console.WriteLine(dtoMap.AuthorId);
        }
        public static void ConfigureAutomapper()
        {
            Mapper.Initialize(expr => {
                expr.CreateMap<Book, BookDto>();
                expr.CreateMap<Author, AuthorDto>();
            });
        }
    }
}
