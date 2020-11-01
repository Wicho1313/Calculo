#include <stdio.h>
#include <math.h>
#include <iostream.h>
int main(){
	float a,b,h,r;
	int n,p,j;
	printf("Se calculara el area bajo la curva de la ecuacion x^3-4x^2+3x-2");
	printf("\n Ingrese el valor de a: ");
	scanf("%f",&a);
	printf("\n Ingrese el valor de b: ");
	scanf("%f",&b);
	printf("\nIngrese el numero de particiones ");
	scanf("%d",&n);
	printf("\nPor Arriba=1 o bien por Abajo=2 :   ");
	scanf("%d",&p);
	h=((b-a)/n);
	if(p==1){
		for(j=1;j<=n;j++){
				if(j==1){
				    
					r=(h*((pow(a,3))-4*(pow(a,2))+3*(a)-2));
				}else{
					
				a=a+h;   
				r=r+(h*((pow(a,3))-4*(pow(a,2))+3*(a)-2));	
				}	
			}
			printf("\nEl valor aproximado del area por arriba es %.3f",r);
	}if(p==2){
		for(j=1;j<=n;j++){
				if(j==1){
					
					r=(h*((pow(b,3))-4*(pow(b,2))+3*(b)-2));
					
				}else{
				b=b-h; 
				  
				r=r+(h*((pow(b,3))-4*(pow(b,2))+3*(b)-2));	
					
				}	
			}
			printf("\nEl valor aproximado del area por abajo es %.3f",r);			
	}
	system("pause");
}

