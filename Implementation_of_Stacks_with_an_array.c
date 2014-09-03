/* Implementation of Stacks with an array */
#include<stdio.h>
#define MAXSTACK 10
#define TRUE 1
#define FALSE 0

int stack_array[MAXSTACK]; /* stack */
int cell = 0; 			   /* global counter , we assume that the stack is empty */
int *pointer_stack;       

/* function push , pre: The stack exists and it is not full , post:The argument item has been stored at the top of the stack */
int push(int element1)
{
	stack_array[cell] = element1;
	cell++;	
	return cell;
}

/*function pop , pre: The stack exists and it is not empty , post: The top of the stack has been removed and returned  */
int pop ()
{
		cell--;
	return cell;
}

/*function empty. post: Return TRUE if the stack is empty, FALSE otherwise*/
int empty()
{
	if(cell == 0)
		return TRUE;
	else
		return FALSE;
}

/* function full post: Return TRUE if the stack is full, FALSE otherwise */
int full()
{
	if(cell == MAXSTACK)
		return TRUE;
	else 
		return FALSE;
}

/*function clear post: All entries in the stack have been deleted, the stack is empty*/
int clear()
{
	cell = 0;
	
	return cell;
}

int main()
{
	int element2,booll,option,key,j;
	int cell2 = 0; /* local counter , we assume that the stack is empty */
	
	do
	{
	location0:;
	booll = FALSE;
	key = 0;
	printf("\n\n");
	printf("Function of a stack, hear are some options\n\n");
	printf("---------------------Options------------------------\n\n");
	printf("1:\tPush an element into the stack, type:     1\n");
	printf("2:\tExtract an element from the stack, type:  2\n");
	printf("3:\tClean the stack, type:                    3\n");
	printf("4:\tBoolean empty, type:                      4\n");
	printf("5:\tBoolean full, type:                       5\n");
	printf("6:\tPrint the stack, type:                    6\n");
	printf("7:\tEnd program, type:                        7\n");	
	printf("---------------------Options------------------------\n\n");
	printf("\nGive an option from above, please write the key number as it is\t:");
	scanf("%d",&option);
	
		if ( option == 1) /* PUSH */
		{
			while(cell2<MAXSTACK)
			{
				printf("\nGive an integer for insertion\t:");
				scanf("%d",&element2);
				j+1;
				cell2 =  push(element2);
				
				printf("\nif you do not want to insert another element, please write 1\t:");
				scanf("%d",&booll);
				
				if (booll == 1)
					break;
			}
		}
		else if ( option == 2) /*POP*/
		{
			while(cell2 != 0)
			{
				cell2 =  pop();
				j-1;
				printf("\nif you do not want to extract another element, please write 1\t:");
				scanf("%d",&booll);
				
				if (booll == 1)
					break;
			}
		}
		else if ( option == 3) /* CLEAR*/
		{
			cell2 = clear();
			j=0;
			printf("\nRESULT:\tThe stack has been cleared\n");
		}
		else if ( option == 4) /* EMPTY */
		{
			booll = empty();  /* RETURNS TRUE OR FALSE */
			
			if (booll == 1 )
			{
				printf("\nRESULT:\tThe stack is empty\n");
				printf("\nPlease give an integer to proceed\n");
				scanf("%d",&key);
			}
			else 
			{
				printf("\nRESULT:\tThe stack is not empty\n");
				printf("\nPlease give an integer to proceed\n");
				scanf("%d",&key);
			}
		}
		else if ( option == 5) /* FULL */
		{
			booll = full();	/* RETURNS TRUE OR FALSE */
			
			if (booll == 1)
			{
				printf("\nRESULT:\tThe stack is full\n");
				printf("\nPlease give an integer to proceed\n");
				scanf("%d",&key);
			}
			else 
			{
				printf("\nRESULT:\tThe stack is not full\n");
				printf("\nPlease give an integer to proceed\n");
				scanf("%d",&key);
			}
		}
		else if(option == 6) /* PRINT */
		{
			break;
		}
		else if ((option < 1) || (option > 7)) 
		{
			printf("\nERROR:\tYou did not gave a correct option, please give an integer to try again\n");
			scanf("%d",&key);	
		}
	}while (option !=7);
	
	printf("\nHere are the elements of the stack,the summit of the stack is the last element :\n\n");
	
	pointer_stack = stack_array; /* pinpoints the first place of the array */
	
	printf("-------------------------------------STACK--------------------------------------\n");
	printf("PLACE\t\t\t\tELEMENT\t\t\t\tADDRESS IN MEMORY\n");
	for (j=0;j < cell2 ; j++)
		{
		printf(" %d\t\t\t\t  %d\t\t\t\t  %d\n",j+1,*pointer_stack,pointer_stack);
		pointer_stack++;
		}
	printf("-------------------------------------STACK-------------------------------------\n\n");
	
	printf("If you want to continue in option menu, Type 1 : ");
	scanf("%d",&key);
	
	if (key == 1)
		goto location0; 
	return 0;
}
		