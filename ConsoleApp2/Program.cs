using ConsoleApp;
using ConsoleApp2;

var uow = new UOW();
uow.GetBookRepository().Add(new Book { Id=0});
Console.WriteLine(uow.GetBookRepository().GetAll().Count());
var repo= uow.GetBookRepository();
Console.WriteLine(repo.GetAll().Count());
uow = new UOW();
Console.WriteLine(uow.GetBookRepository().GetAll().Count());

