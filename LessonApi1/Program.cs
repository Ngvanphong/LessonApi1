
// in ra mang hinh;
//
//


/*
 * this is comment 
 * this ti htis 
 * 
 * 
 */

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
    }
    //Console.WriteLine(i);
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















