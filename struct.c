#include <stdio.h>
#include <stdlib.h>

struct postgraduate_student
{
    int am;
    char surname[30];
    char name[30];
    char fathers_name[20];
    char mothers_name[20];
    char address[40];
    char telephone[14];
    char mobile[14];
    char selected_subject[30];
};

int main()
{
	int b;
	int i,number; 
	struct postgraduate_student *pointer;
    char mathima[30]; 

	printf("give number of students\n");
	scanf("%d",&number);

	struct postgraduate_student students[number]; /* array of structure */

	for (i=0; i < number; i++)
	{
		printf("Enter AM: ");
		scanf("%d",&students[i].am);

		printf("Enter surname: ");
		scanf("%s",&students[i].surname);

		printf("Enter name: ");
		scanf("%s",&students[i].name);

		printf("Enter fathers name: ");
		scanf("%s",&students[i].fathers_name);

		printf("Enter mothers name : ");
		scanf("%s",&students[i].mothers_name);

		printf("Enter address: ");
		scanf("%s",&students[i].address);

		printf("Enter telephone: ");
		scanf("%s",&students[i].telephone);

		printf("Enter mobile: ");
		scanf("%s",&students[i].mobile);

		printf("Enter selected subject: ");
		scanf("%s",&students[i].selected_subject);
		
		printf("\n\n");
    }


    for (i=0; i < number; i++)
	{
	    printf("%d\n%s\n%s\n%s\n%s\n%s\n%s\n%s\n%s\n\n",
            students[i].am, students[i].surname, students[i].name, students[i].fathers_name,
            students[i].mothers_name, students[i].address, students[i].telephone, students[i].mobile,
            students[i].selected_subject);
	}

	pointer = students;


    printf("give subject of preference\n");
    scanf("%s", &mathima);
	b = 0;  
    printf("students of %s: ", mathima);
    for (i=0;i<number;i++) 
	{
        if (strcmp((*pointer).selected_subject,mathima)==0)		/* comparison of the two strings */ 
		{
			b = 1;
            printf("%s %s\n",students[i].surname, students[i].name); 
		}
			pointer += 1;
    }
    if (b==0)
		printf("this subject is not selected by anyone\n");
		
    free(students);

	return 0;
}

