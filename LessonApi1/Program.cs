
using LessonApi1.Oop2;

Rebar rebar1 = new Rebar();
rebar1.Id = 1;
rebar1.Length = 1;
rebar1.Desity = 75;
rebar1.Raidus = 1;

Rebar rebar2= new Rebar();
rebar2.Id = 2;

Rebar rebar3= new Rebar();
rebar3.Id = 3;


List<Rebar> rebars= new List<Rebar>();
rebars.Add(rebar1);
rebars.Add(rebar2); 
rebars.Add(rebar3);

//foreach(Rebar rebar in rebars)
//{
//    Console.WriteLine(rebar.Id);
//}
ICollection<Rebar> rebarCollection = new List<Rebar>();
rebarCollection.Add(rebar1);
rebarCollection.Add(rebar2);


IEnumerable<Rebar> rebarEnumerable = new List<Rebar>() { rebar1,rebar2};
foreach (Rebar rebar in rebarEnumerable)
{
    Console.WriteLine(rebar.Id);
}

















