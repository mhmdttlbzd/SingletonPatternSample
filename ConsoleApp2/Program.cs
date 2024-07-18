using ConsoleApp;
using ConsoleApp2;
using Presentation;

var uow = new UOW();
uow.GetBookRepository().Add(new Book { Id=0});
Console.WriteLine(uow.GetBookRepository().GetAll().Count());
var repo= uow.GetBookRepository();
Console.WriteLine(repo.GetAll().Count());
uow = new UOW();
uow.GetBookRepository().Add(new Book { Id=2});
Console.WriteLine(uow.GetBookRepository().GetAll().Count());

var repo2 = BookRepository2.GetClass();
repo2.GetBooks();
