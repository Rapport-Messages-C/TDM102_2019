#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	int A;
	int B;
	float C;
	float D;
	char E;
	char F;
	printf ("Donnez un nombre entier : ");
	scanf ("%d" ,&A);
	printf ("Donnez un nombre entier : ");
	scanf ("%d" ,&B);
	printf ("Donnez un nombre reel : ");
	scanf ("%f" ,&C);
	printf ("Donnez un nombre reel : ");
	scanf ("%f" ,&D);
	fflush(stdin);
	printf ("Donnez un caracter : ");
	scanf ("%c" ,&E);
	fflush(stdin);
	printf ("Donnez un caracter : ");
	scanf ("%c" ,&F);
	if (A>B) {
		printf ("Le nombre maximal est : %d \n",A);
	} else {
		printf ("Le nombre maximal est : %d \n",B);
	}
	if (C>D) {
		printf("Le nombre maximal est : %f \n",C);
	} else {
		printf("Le nombre maximal est : %f \n",D);
	}
	if (E>F) {
		printf("Le caracter maximal est : %c \n",E);
	} else {
		printf("Le caracter maximal est : %c \n",F);
	}
	system("PAUSE");
	return 0;
}
