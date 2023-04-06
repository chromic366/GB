int a = 22;
int b = 15;
int c = 6;
int d = 8;
int e = 4;

int max = a;

if(b > max) max = b;
if(c > max) max = c;
if(d > max) max = d;
if(e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);