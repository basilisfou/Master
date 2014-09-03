

/*--------------------------------------*/
/********* Simple Planning **************/
/* 1. Develop a simple Planning         */
/* representation system for the 3-cube	*/
/* world				*/
/*--------------------------------------*/
/* freecube(Cube)  			*/
/* oncube(Cube1,Cube2) 			*/
/* ontable(Cube)   			*/
/*--------------------------------------*/
:- dynamic freecube/1, ontable/1, oncube/2.

/*--------------------------------------*/
/* current_state 			*/
/*--------------------------------------*/
/* Question (b) */
freecube(a).
ontable(d).
oncube(a,b).
oncube(b,c).
oncube(c,d).


/*--------------------------------------*/
/* Actions 				*/
/*--------------------------------------*/
/* 1st action pickup cube X from table 	*/
/* and leave it on other cube Y		*/
/*--------------------------------------*/
puton(X,Y) :- 
	/* preconditions */
	ontable(X),
	freecube(Y),
	/* effects */
	assert(oncube(X,Y)),
	retract(freecube(Y)),
	retract(ontable(X)).

/*--------------------------------------*/
/* 2nd action putdown cube X which is 	*/
/* on Y and put it on table		*/
/*--------------------------------------*/
putdown(X) :- 
	/* preconditions */
	oncube(X,Y),
	freecube(X),
	/* effects */
	assert(ontable(X)),
	assert(freecube(Y)),
	retract(oncube(X,Y)).

/*--------------------------------------*/
/* For Goal state_b, plan_b		*/
/*--------------------------------------*/
/*
freecube(c).
ontable(b).
oncube(c,a)
oncube(a,d).
oncube(d,b).
*/

plan_b :- 
	putdown(a), putdown(b), putdown(c), 
	puton(d,b), puton(a,d), puton(c,a).


























