namespace RepoPattern
{
    public class Program
    {
        public static void Main()
        {
            IRepository<NameId> repo = new RepoClass<NameId>();
            var nameId1 = new NameId { Id = 1, Name = "john" };
            repo.Add(nameId1);


            foreach(var pott in repo.GetAll()){
                Console.WriteLine($"{pott.Id} {pott.Name}" );
            }
        }
    }
}