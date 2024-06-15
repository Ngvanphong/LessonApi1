
// in ra mang hinh;
//
//


/*
 * this is comment 
 * this ti htis 
 * 
 * 
 */

using LessonApi1;
using LessonApi1.CreateColumn;

int a = 2;
int b = 3;
int totalInt = a + b; // cu phap lac da

double c = 0;

bool isTrue= true;  // tra ve true or false;

isTrue = 10 == 11;


// Type 

short numberShort=-1;

ushort numberUShort=1;

int numerInteger=-10;

uint numerUInteger=10;

long numerLong = 10;

ulong numerULong= 10;

float numerFloat = 10.1f;

double numberDouble = 10;

decimal money = 10000;

char textChar = 'a';

string textMultiString = "Monday \n Tuesday";

string textMultiString2 = @"Monday \n Tuesday";

decimal numberDecimal = -10000000;


double number1 = 7;
double number2 = 5;

double totalNumner= number1 / number2;

bool isCompare= !(number1 <= number2);

bool isCompare2 = number1 != number2;


bool isCompare3 = (number1 != number2) && (number1 != 10);

bool isCompre4 = !(number1 == number2) || (number1 != 10 && number1==10);


number1++;
number1--;
++number1;
--number1;
number1 += 10;
number1 -= 10;

double resultNumber= (isCompre4==true && 10==12)? number1 : number2;

double double1 = 5; // 101
double double2 = 4; // 100

var isRef= 5 | 4;   //   101


var textString2 = $"This is value {number1}";

var textString3 = "This is value " + number2.ToString();

var textString4 = string.Format("This is value {0} - {1} = {2}", number1, number2,10);

string text4 = "This is monday";
var substring = text4.Substring(8,3);

double number5 = 10;
if (number5 == 5)
{
    Console.WriteLine($"This is {number5}");
}
else if(number5 == 7)
{
    Console.WriteLine("Asaaa");
}
else if(number5 == 8)
{
    Console.WriteLine("BBB");
}
else
{
    Console.WriteLine("Default");
}

double result = number5 == 10 ? 11 : 12;

for(int i = 1;i <= 10; i+=5)
{
    if (i == 2)
    {
        continue;
        //break;
    }
    Console.WriteLine(i);
}



int index = 1;
double sum = 11;
while (sum<10)
{
    sum += index;
    if (sum > 5)
    {
        continue;
    }
    Console.WriteLine(sum);
}


do
{
    Console.WriteLine(sum);
    sum++;
} while (sum<13);


double n = 10; //10 9 8 ...1;

double giaithua = 1;
while (n > 0)
{
    giaithua *= n;
    n--;
}

Console.WriteLine(giaithua);

double total = 0;
for(int i =0; i< 10; i++)
{
    Console.WriteLine(i);
    for(int j = 0;j<10; j++)
    {
        total += 1;
        if (total == 5)
        {
            break;
        }
    }
}

int today = 8;

switch (today)
{
    case 0:
        Console.WriteLine("Thu 2");
        break;
    case 1:
        Console.WriteLine("Thu 3");
        break;
    case 2:
        {
            Console.WriteLine("thu 4");
            break;
        }
    default:
        {
            Console.WriteLine("Chu nhat");
            break;
        }

}


int[] intArray= new int[10];

for(int i =0; i < 10; i++)
{
    intArray[i] = 15;
}

intArray[5] = 30;

foreach(int item in intArray)
{
    Console.WriteLine(item);
}

double[] doubleArray = new double[4] { 10, 25, 16, 20 };

int countTotal = doubleArray.Length;

double[] doubleArray2 = { 1, 2, 3 };

double? nullAbleDouble;

foreach(double valueDouble in doubleArray)
{
    Console.WriteLine(valueDouble);
}

int[,] twoDimension = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 4,2 } };
twoDimension[0, 1] = 5;

for(int i = 0; i < 3; i++)
{
    for(int j = 0; j < 2; j++)
    {
        Console.WriteLine($"[{i}][{j}]={twoDimension[i, j]}");
    }
}

int[][] jaggedDimension = new int[3][];
jaggedDimension[0] = new int[3] { 4, 7, 2 };
jaggedDimension[1] = new int[2] { 5, 4 };
jaggedDimension[2] = new int[3] { 7, 4, 5 };

int countParent = jaggedDimension.Length;

int countChild1 = jaggedDimension[1].Length;


AirDuct airDuct1 = new AirDuct(1000,1000,"Steel");


var height=airDuct1.Height;
airDuct1.Height = 20;

double area1 = airDuct1.AreaCalculation();
airDuct1.Print(area1);

airDuct1.Calc(10, 5, 1);
airDuct1.Calc(10, 5,10,false);

double volum1 = airDuct1.VolumnCal(3);

volum1= AirDuct.VolumnCal(3);

AirDuct airDuct2 = new AirDuct();
airDuct2.Width = 2000;
airDuct2.Height = 200;

AirDuct airDuct3 = new AirDuct("aaa", "bbb");



Beam beam1= new Beam();
beam1.Id = 10;
beam1.Name = "Beam1";
beam1.Volume = 100;
beam1.PrintMoniter();

Column column = new Column();

Element element = new Element();
element.Width = 100;
element.Length = 200;
double area= element.AreaCal(element.Width, element.Length);
double perimeter= element.PerimeterCal(element.Width,element.Length);

Console.WriteLine(area);
Console.WriteLine(perimeter);


Rectangle hcn = new Rectangle(10,20);


Sqare sq = new Sqare(10, 12);
sq.PrintMoniter();


Rectangle rc=  new Rectangle(10,20);    
rc.PrintMoniter();


Column colum2 = new Column();
colum2.Pri


//Console.WriteLine(airDuct1.Material);



























