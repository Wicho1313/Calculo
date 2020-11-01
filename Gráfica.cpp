#include <iostream.h>
#include <math.h>
using namespace std;
float calcularFuncion(float x);
int main ()
{
int j, a, b, p;
double r, h, n=0.0;
cout<<"ingrese el limite inferior: "<<endl;
cin>>a;
cout<<"ingrese el límite superior: "<<endl;
cin>>b;
cout<<"ingrese las particiones: "<<endl;
cin>>n;
cout<<"Por arriba=1 o bien por abajo=2"<<endl;
cin>>p;
	h=(b-a)/n;
if(p==1){
		for(j=1;j<=n;j++){
				if(j==1){
				    
					r=(h*((pow(a,3))-4*(pow(a,2))+3*(a)-2));
				}else{
					
				a=a+h;   
				r=r+(h*((pow(a,3))-4*(pow(a,2))+3*(a)-2));	
				}	
			}
			cout<<"El area por arriba es: "<<r<<endl;
}
if(p==2){
		for(j=1;j<=n;j++){
				if(j==1){
					
					r=(h*((pow(b,3))-4*(pow(b,2))+3*(b)-2));
					
				}else{
				b=b-h; 
				  
				r=r+(h*((pow(b,3))-4*(pow(b,2))+3*(b)-2));	
					
				}	
			}
          cout<<"El area por debajo es: "<<r<<endl;		
	}
	system("pause");
	system("cls");
}

