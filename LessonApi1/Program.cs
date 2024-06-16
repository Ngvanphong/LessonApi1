
using LessonApi1;
using LessonApi1.Oop2;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Transactions;

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
//foreach (Rebar rebar in rebarEnumerable)
//{
//    Console.WriteLine(rebar.Id);
//}

HashSet<string> listName = new HashSet<string>() { "1", "2", "3", "2", "3" };
foreach (string name in listName)
{
    Console.WriteLine(name);
}

ArrayList arrayList= new ArrayList();
arrayList.Add(rebar1);
arrayList.Add(rebar2);
arrayList.Add(1);


Structure st1 = rebar2;

double b = 30;
int c = (int)b;

Structure st3 = new Structure();


Rebar rebar5= st3 as Rebar;

Rebar rebar6 = (Rebar)st3;

bool isTrue = st3 is Rebar;
if (isTrue)
{

}


Console.WriteLine(isTrue);

Queue<Rebar> queueRebar = new Queue<Rebar>();
queueRebar.Enqueue(rebar1);
queueRebar.Enqueue(rebar2);

Stack<Rebar> stackRebar = new Stack<Rebar>();
stackRebar.Push(rebar1);
stackRebar.Push(rebar2);

Console.WriteLine("");


double addDouble = Add<double>.AddCal(12.5, 6.5);

float addFloat = Add<float>.AddCal(1.3f, 4.5f);

int addInt = Add<int>.AddCal(1, 3);
























