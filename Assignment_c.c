/*
******************************
*  8         8    888888888  *
*   8       8     8          *
*    8     8      888888888  *
*     8   8       8          *
*      8 8        8          *
*       8     .   8         .*
******************************
*/

#include <stdio.h>
#define FLOOR 5						/* in the block */
#define APARTMENTS 10				/* in one floor */

struct info_apartments
{
	char tenant[20];
	char name[40]; 							/* name of proprietor of apartment */ 
	int num_apartment; 						/* number of apartment */
	float squared_meters; 					/* size of apartment */
	int floor_apar; 						/* floor of the apartment */
}list[50] = 			 {"tenant1","Vasileios Fouroulis",1,95,1,
						  "tenant2","Georgios Fouroulis",2,100,1,
						  "tenant3","Maria Destouni",3,89,1,
						  "tenant4","Kuriaki Panagiotarou",4,78,1,
						  "tenant5","Xrysa Vrioni",5,45,1,
						  "tenant6","Iasonas Fouroulis",6,123,1,
						  "tenant7","Iolaos Iokimidis",7,91,1,
						  "tenant8","Panagiotis Tzaferidis",8,134,1,
						  "tenant9","Dimitrios Xaidemenos",9,65,1,
						  "tenant10","Marios Fragkoulis",10,98,1,
						  "tenant11","Aleksandros Xalkias",11,95,2,
						  "tenant12","Vasilios Kritikakis",12,100,2,
						  "tenant13","Athia Tsitsipi",13,89,2,
						  "tenant14","Anna Amorgianou",14,78,2,
						  "tenant15","Xaris Kaligeris",15,45,2,
						  "tenant16","Iwanna Giannopoulou",16,123,2,
						  "tenant17","Manwlis Fouroulis",17,91,2,
						  "tenant18","Gewrgios Nisiwtis",18,134,2,
						  "tenant19","Thanos Tziouvelis",19,65,2,
						  "tenant20","Pexlivanis Petros",110,98,2,
						  "tenant21","Anastasia Salakou",21,95,3,
						  "tenant22","Iwannis Papafanis",22,100,3,
						  "tenant23","Iwannis Kotsampas",23,89,3,
						  "tenant24","Petros Petridis",24,57,3,
						  "tenant25","Stratos Petros",25,45,3,
						  "tenant26","Nefeli Skons",26,74,3,
						  "tenant27","Mixalis Vrionis",27,43,3,
						  "tenant28","Inioxos Depastas",28,41,3,
						  "tenant29","Stelios Fouroulis",29,85,3,
						  "tenant30","Giannis Markantonakis",210,54,3,
						  "tenant31","Patritsia Petsiti",41,95,4,
						  "tenant32","Valentina Aggeli",42,100,4,
						  "tenant33","Kouvaritakis Iraklis",43,89,4,
						  "tenant34","Nansy Karaindrou",44,78,4,
						  "tenant35","Fotini Mira",45,45,4,
						  "tenant36","Elena Karaiskou",46,123,4,
						  "tenant37","Panagiotis Zogopoulos",47,92,4,
                          "tenant38","Mixalis Giamalakis",48,134,4,
						  "tenant39","Maria Mastrapa",49,65,4,
						  "tenant40","Evi Siola",410,98,4,
						  "tenant41","Nantia Ntavarinou",51,95,5,
						  "tenant42","Dimitris Triantopoulos",52,100,5,
						  "tenant43","Gerasimos Gardelis",53,89,5,
						  "tenant44","Giannis Nasioulas",54,78,5,
						  "tenant45","Napolewn Adamos",55,45,5,
						  "tenant46","Paulos Fafalios",56,123,5,
						  "tenant47","Tserikonis Panagiotis",57,92,5,
						  "tenant48","Vasilis Savvadis",58,134,5,
						  "tenant49","Olga Mpelou",59,65,5,
						  "tenant50","Eirini Mparouxou",510,98,5};

struct info_apartments *pointer_list; 

void print_total_meters() /*function that calculates the total meters^2 for each floor */
{
	float sum_floor;
	int i,j;
	pointer_list = list; /*initialization for the pointer to pinpoints in the first place of array list */
	
	for(i=0;i<FLOOR;i++)
	{
	sum_floor=0;
		for (j=0;j<APARTMENTS;j++)
			{
				sum_floor = sum_floor + pointer_list->squared_meters;
				pointer_list++;
			}
		printf("The square meters for the floor %d are :%.2f\n",i+1,sum_floor);	
	}		
}

float block_meters() /*calculating the total surface of the block*/
{
	pointer_list = list; /*initialization for the pointer to pinpoints in the first place of array list */
	float total_squareMeters = 0;
	int k;
	
	for (k=0;k<FLOOR*APARTMENTS;k++)
	{
		total_squareMeters = total_squareMeters + pointer_list->squared_meters;
		pointer_list++;
	}
	
	return total_squareMeters;
}
	
void print_tenants_expenses (float a)
{
	int i;
	struct info_apartments *pointer_list2; /* new pointer because we use the function block_meters() and the pointers conflict each other */
	pointer_list2 = list; /*initialization for the pointer to pinpoints in the first place of array list */
	float apartment_expenses; /* expenses of each apartment */
	
	for (i=0;i<FLOOR*APARTMENTS;i++)
	{
		apartment_expenses = pointer_list2->squared_meters*a/block_meters(); 
		printf("Amount:%.2f EURO\tNAME: %s\n",apartment_expenses,pointer_list2->name);
		pointer_list2++;
	}
}

void print_apartment_expenses(int num_apartment2, float shared_expenses2)
{
	struct info_apartments *pointer_list3; /* new pointer because we use the function block_meters() and the pointers conflict each other*/
	pointer_list3 = list;
	int i;
	float apartment_expenses;
	for(i=0;i<50;i++)
	{
		if (pointer_list3->num_apartment == num_apartment2)
			{
				apartment_expenses = pointer_list3->squared_meters*shared_expenses2/block_meters();
				printf("NUMBER OF APARTMENT: %d\tAmount: %.2f EURO\n",pointer_list3->num_apartment,apartment_expenses);
			}
			else
			{
				printf("You didn't give a correct number\n");
				break;
			}
		pointer_list3++;
	}
}

void biggest_tenant () /*printing the tenant with the biggest apartment in the floor*/
{
	int i,j;
	pointer_list = list; /*initialization for the pointer to pinpoints in the first place of array list */
	float max =0;
	struct info_apartments *p;
	for(i=0;i<FLOOR;i++)
		{	
		for (j=0;j<APARTMENTS;j++)
			{
				if (max < (pointer_list)->squared_meters)
					{
						max = pointer_list->squared_meters;
						p = pointer_list;
						pointer_list++;
					}
				else 
					pointer_list++;
			}
			printf("For the floor %d the name of the tenant with the biggest apartment is %s\n",i+1,p->name);
			max = pointer_list->squared_meters;
		}		
}
		
int main()
{
int option,key,i,number_apartment,j;
float shared_expenses;
struct info_apartments *pointer; 
do
	{
	printf("\nOPTION MENU\n\n");
	printf("---------------------------------MENU------------------------------------\n\n");
	printf("1:\tgive the total expenses of the block, essential for option 3,4 :        1\n");
	printf("2:\tCalculate the total square meters for each floor, type:                 2\n");
	printf("3:\tPrint the name of each tenant and the amount that he has to pay, type:  3\n");
	printf("4:\tPrint the number of the apartment and the amount of expenses, type:     4\n");
	printf("5:\tName of the tenant with the biggest apartment of each floor, type:      5\n");
	printf("6:\tEnd program, type:                                                      6\n");	
	printf("---------------------------------MENU------------------------------------\n\n");
	printf("\nGive an option from above, please write the key number as it is\t:");
	scanf("%d",&option);
	
	if (option == 1) /* essential step for the option 3,4 to work */
	{
		printf("\n\ngive the total expenses of the block:");
		scanf("%f",&shared_expenses);
	}
	else if ( option == 2)
		{
		print_total_meters(); /*printing the square_meters for each floor */
		
		printf("\nGive any integer to proceed or 2 to exit\n");
		scanf("%d",&key);
		
		if (key == 2)
			break;
		}
	else if ( option == 3)
	{
		printf("\nHere are the names of the tenants and the amount of the shared_expenses that they have to pay\n\n");
		printf("-----------------------------------------------------------\n");
		print_tenants_expenses(shared_expenses);
		printf("-----------------------------------------------------------\n\n");
		
		printf("\nGive any integer to proceed or 2 to exit\n");
		scanf("%d",&key);
		
		if (key == 2)
			break;
	}
	else if(option == 4)
	{
	pointer = list; /*initialization for the pointer to pinpoints in the first place of array list */
	
	printf("\nPlease check the numbers of apartments \n");
	for (i=0;i<FLOOR;i++)
	{
		printf("FLOOR %d :",i);
		for (j=0;j<APARTMENTS;j++)
		{
		printf("%d,",pointer->num_apartment);
		pointer++;
		}
		printf("\n");
	}
		printf("Choose the number of the apartment for the program to print the expenses:");
		scanf("%d",&number_apartment);
		printf("\n");
		
		print_apartment_expenses(number_apartment,shared_expenses);
		
		printf("\nGive any integer to proceed or 2 to exit\n");
		scanf("%d",&key);
		
		if (key == 2)
			break;
	}
	else if(option == 5)
	{
	biggest_tenant();
	
	printf("\nGive any integer to proceed or 2 to exit\n");
	scanf("%d",&key);
		
	if (key == 2)
		break;
	}
	else if ((option < 1) || (option > 6)) 
		{
			printf("\nERROR:\tYou did not gave a correct option, please give an integer to try again\n");
			scanf("%d",&key);	
		}
	
	}while (option !=6);

return 0;
}
	