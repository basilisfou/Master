#include <stdio.h>
#include <malloc.h>
#include <stdlib.h>
#define SIZE 10 /* size of stack */

struct process
{
	int pid; /* id of process */
	int ppid; /* id of parent process */
	char status[8]; /* run , blocked or ready */
	char user_name[7]; 
	char description[50];
	struct process *next; /* pinpoints the next node */
};

typedef struct process PROCESS;
typedef PROCESS *mynode;

mynode new,head;  
int i = 0;

void empty() /* boolean */
{
	if (head == NULL)
		printf("The stack is empty\n");
	else 
		printf("The stack is not empty\n");
}
void full()
{
	if (i == SIZE)
		printf("The stack is full\n");
	else 
		printf("The stack is not full\n");
}
void push() /* inserts an element to the stack */
{
	if (i <  SIZE)
	{
	mynode current; /*to run the list- stack*/
	
	current = head; 
	new = NULL;
		if (current == NULL) /* if there is no node */
		{
			new = (mynode)malloc(sizeof(mynode));
			new->next = head;
			head = new;
			printf("Give pid for the new process \n");
			scanf("%d",&new->pid);
		
			printf("Give ppid for the new process \n");
			scanf("%d",&new->ppid);
		
			printf("Give status for the new process \n");
			scanf("%s",&new->status);
		
			printf("Give user_name for the new process \n");
			scanf("%s",&new->user_name);
		
			printf("Give description for the new process \n");
			scanf("%s",&new->description);	
			i++;
		}
		else
		{
			while( current-> next != NULL ) 
			current = current -> next;
		
			new = (mynode)malloc(sizeof(PROCESS)); /*creating a new node */
			current->next =new;	
			new->next =NULL;

			printf("Give pid for the new process \n");
			scanf("%d",&new->pid);
		
			printf("Give ppid for the new process \n");
			scanf("%d",&new->ppid);
		
			printf("Give status for the new process \n");
			scanf("%s",&new->status);
		
			printf("Give user_name for the new process \n");
			scanf("%s",&new->user_name);
		
			printf("Give description for the new process \n");
			scanf("%s",&new->description);	
			i++;
		}
	}
	else
		printf("The stack is full\n");
}

void pop()
{
	if(i > 0)
		{
		mynode current1;
		current1 = head;
		if(i>=2)
		{
		mynode current2;
		current2=current1->next;
		
		while ( current2 ->next !=NULL ) /* run the list until the current2 pinpoints the last node*/
		{
			current1 = current2;
			current2 = current1->next;
		}
	
		current1->next=NULL;
		free(current2);
		}
		else if (i==1)
		{
				
			head=NULL;
			free(current1);
		}
		
		i--;
		}
	else
		printf("The stack is empty\n");
}

void clean()
{
	head = NULL;
	i=0;
}

void print()
{
    mynode temp;
	
    temp = head;
	printf("\nHere are the elements of the stack,the bottom of the stack is the element that entered last in the stack:\n\n");
	
	printf("-------------------------------------STACK--------------------------------------\n");
	printf("pid\tppid\tstatus\t\tuser name\tdescription\n");
    while (temp != NULL) 
	{
        printf("%d\t%d\t%s\t\t%s\t\t%s\n",temp-> pid,temp->ppid,temp->status,temp->user_name,temp->description);
        temp = temp->next;
    }
	printf("-------------------------------------STACK--------------------------------------\n\n");
    printf("\n");
}
	
int main()
{
	int option;
	
	head = NULL; /* create an empty stack */
	do
	{
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
	
	switch (option)
	{
	case 1:
	{
		push();
		break;
	}
	case 2:
	{
		pop();
		break;
	}
	case 3:
	{
		clean();
		break;
	}
	case 4:
	{
		empty();
		break;
	}
	case 5:
	{
		full();
		break;
	}
	case 6:
	{
		print();
		break;
	}
	case 7:
		break;

	default:
		printf("\nERROR:\tYou did not give a correct option,try again\n");
	}
	
	}while(1);	
	
return 0;
}