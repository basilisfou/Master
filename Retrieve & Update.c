#include<stdio.h>

void retrieve(double array[], double *n, int i)						/* retrieve , this function assigns in a variable 
																	the price of an element of an array that corresponds
																	to a pointer i */
{
	*n = array[i];
}

void update(double array[], double n, int i)						/* update, this function assigns the price of a variable
																	in an element of an array that corresponds to a pointer i */
{
	array[i] = n;
}

int main()
{
    int i;
    double x,y,z;
    double A[10],B[10],C[10];
	 
    for(i=0;i<10;i++)												/* fulling the array */
    {
      printf("give elements for array B\n");									
      scanf("%lf",&B[i]);

      printf("give elements for array C\n");
      scanf("%lf",&C[i]);
	}
	for(i=0;i<10;i++)
    {
	retrieve(B,&x,i);    											/* retrieve*/
	retrieve(C,&y,i);
	
	z = x+y;    													/* summing the two arrays */

	update(A,z,i);													/* update */
    }
    printf("\nThe elements of A are:\n");
    
	for(i=0;i<10;i++)
		printf("%d : %.2lf\n",i,A[i]);								
	
	
return 0;
}



