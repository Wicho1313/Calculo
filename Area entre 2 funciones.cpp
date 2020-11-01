#include <iostream.h>
#include <math.h>
using namespace std;
int main ()
{
float m, b, a1, b1, c1, k, q, r;
double x1, x2;
cout<<"Ingrese m: ";
cin>>m;
cout<<"Ingrese b: ";
cin>>b;
cout<<"Ingrese a1: ";
cin>>a1;
cout<<"Ingrese b1: ";
cin>>b1;
cout<<"Ingrese c1: ";
cin>>c1;   
k=(b1-m);
q=(c1-b);
x1=(-k+sqrt(k*k-4*a1*q))/(2*a1);
x2=(-k-sqrt(k*k-4*a1*q))/(2*a1);
if(x1>x2)
{
 cout<<"El limite superior es: "<<x1<<endl;
 cout<<"el limite inferior es: "<<x2<<endl;
 r=((((a1*pow(x1,3))/(3))+((k*pow(x1,2))/(2))+((q*x1)))-(((a1*pow(x2,3))/(3))+((k*pow(x2,2))/(2))+((q*x2))));
 if(r<0)
 {
        r=r*-1;
        cout<<"El area es: "<<r<<endl;
 }
 else
 {
         cout<<"El area es: "<<r<<endl;
 }
}
else if(x2>x1)
{
cout<<"El limite superior es: "<<x2<<endl;
 cout<<"el limite inferior es: "<<x1<<endl;
 r=((((a1*pow(x2,3))/(3))+((k*pow(x2,2))/(2))+((q*x2)))-(((a1*pow(x1,3))/(3))+((k*pow(x1,2))/(2))+((q*x1))));
 if(r<0)
 {
        r=r*-1;
        cout<<"El area es: "<<r<<endl;
 }
 else
 {
         cout<<"El area es: "<<r<<endl;
 }
}        
else 
{
cout<<"No se puede factorizar la ecuacion con numeros reales"<<endl;
cout<<"No se pueden establecer los límites"<<endl;
}
system("pause");
}
