#include <stdio.h>
#include <stdlib.h>
using namespace std;

 main(void) {

int a,b,c,d,e,x;
float lim,numerador,denominador,n1,n2,n3,n4,n5,n6,n7,n8,d1,d2,d3,d4,d5,d6,d7,d8,t1,t2,t3,t4,t5,t6,t7,t8; 
	printf("escriba numero A \n");
	scanf("%d", &a);
	
	printf("\nescriba numero B \n");
	scanf("%d", &b);
	
	printf("\nescriba numero C \n");
	scanf("%d", &c);
	
	printf("\nescriba numero D \n");
	scanf("%d", &d);
	
	printf("\nescriba numero E \n");
	scanf("%d", &e);
	
	
	printf("\n%d\n", a);
	printf("%d\n", b);
	printf("%d\n", c);
	printf("%d\n", d);
	printf("%d\n", e);
	printf("%d\n", x);

	numerador = ((b*a)+c);
	printf("numerador = %f\n", numerador);

	denominador = ((d*a)+e);
	printf("denominador = %f\n", denominador);


	n1 = ((b*(a-0.1))+c);
	n2 = ((b*(a-0.05))+c);
	n3 = ((b*(a-0.03))+c);
	n4 = ((b*(a-0.01))+c);
	n5 = ((b*(a+0.01))+c);
	n6 = ((b*(a+0.03))+c);
	n7 = ((b*(a+0.05))+c);
	n8 = ((b*(a+0.1))+c);

	d1 = ((d*(a-0.1))+e);
	d2 = ((d*(a-0.05))+e);
	d3 = ((d*(a-0.03))+e);
	d4 = ((d*(a-0.01))+e);
	d5 = ((d*(a+0.01))+e);
	d6 = ((d*(a+0.03))+e);
	d7 = ((d*(a+0.05))+e);
	d8 = ((d*(a+0.1))+e);

	t1 = n1/d1;
	t2 = n2/d2;
	t3 = n3/d3;
	t4 = n4/d4;
	t5 = n5/d5;
	t6 = n6/d6;
	t7 = n7/d7;
	t8 = n8/d8;


	if(denominador!=0)
		{
			lim = (numerador/denominador);
			printf("El limite de ((b*a)+c)/((d*a)+e) es: %f\n", lim);
			printf("Aqui la tabla:\n");
			printf("f(%d-0.1) = %f\n", a,t1);
			printf("f(%d-0.05) = %f\n", a,t2);
			printf("f(%d-0.03) = %f\n", a,t3);
			printf("f(%d-0.01) = %f\n\n", a,t4);

			printf("f(%d+0.01) = %f\n", a,t5);
			printf("f(%d+0.03) = %f\n", a,t6);
			printf("f(%d+0.05) = %f\n", a,t7);
			printf("f(%d+0.1) = %f\n\n", a,t8);
		}
	else
		{

			printf("El denominador del limite ((%d*%d) + %d) no es vàlido ya que es igual a 0. Favor de modificar para que sea diferente de 0 \n", d,a,e);

		}
system("pause");
}

