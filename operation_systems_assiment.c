/*
****************************
*8         8    888888888  *
* 8       8     8          *
*  8     8      888888888  *
*   8   8       8          *
*    8 8        8          *
*     8     .   8          *
**************************** 
*/



/* Compiled with: gcc operation_systems_assiment.c -lpthread -o executable_file*/

#include <stdio.h>
#include <stdlib.h>
#include <pthread.h>
#include <unistd.h>  							/*vf: fork() */

#define TRUE 1

const clock_t MAXDELAY = 2000000;

void * change_variable(void* m);					/*vf:test power function*/
void change_number(char * namepid, int step);
void delay ( clock_t ticks);

int global_var = 100; 									

void delay ( clock_t ticks)						/*vf: delay */
{
	clock_t start = clock();
	do
	; while (clock() < start +ticks);
}

void change_number(char * namepid, int step)
{
	while(TRUE)
	{
	global_var +=step;   						/*vf :raises or reduces the global variable */
	printf("%s: %d\n", namepid,global_var);
	delay(rand()%MAXDELAY);
	}
}


void * change_variable(void* m)
{
	int local_var = 50;
	int i = (int) m;						/*vf :cousting */
	
	while(TRUE)
	{
	local_var = local_var + i;   
	printf("local variable = %d, adjustment  = %d\n", local_var,i );
 	delay(rand()%MAXDELAY);
	}
        return (m);	
}

int main()
{
	int c;
	
	pthread_t thread_1, thread_2; 					/* declaring threads */
	pthread_attr_t *attr;                           /* thread attribute variable */
	attr= NULL; 
	
	srand(time(NULL));
	printf("creating new process:\n");
	c = fork();
	printf("process %d created\n",c);
	if (c == 0)
	{
		printf("creating threads:\n");
		pthread_create(&thread_1,attr,change_variable,(void*)1);
		pthread_create(&thread_2,attr,change_variable,(void*)-1);
		
		change_number("child",2);
	}
	else
		change_number("parent",-1);delay(rand()%MAXDELAY);
	
	return 0;	
}
