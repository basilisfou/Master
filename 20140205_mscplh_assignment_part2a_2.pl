
/* 2nd solution */

/*--------------------------------------*/
/********* Simple Planning **************/
/* 2. Develop a simple Planning         */
/* representation system for the 2-d map*/
/* world				*/
/*--------------------------------------*/

:- dynamic map/1.

/*--------------------------------------*/
/* current_state 			*/
/*--------------------------------------*/
/* Question (a) */

map([
	[0,0,0,0,0],
	[0,1,1,0,1],
	[0,0,0,r,1],
	[0,0,0,0,0]
]).

/*--------------------------------------*/
/* Actions 				*/
/*--------------------------------------*/
/* move(D) (Direction=n,s,w,e)		*/
/*--------------------------------------*/
move(D) :- 
	/* preconditions */
	map(M),
	map_pos(M,C,L,r),
	ifthen(D=n, (NewL is L-1,	NewC is C) ),
	ifthen(D=s, (NewL is L+1,	NewC is C) ),
	ifthen(D=w, (NewL is L,		NewC is C-1) ),
	ifthen(D=e, (NewL is L,		NewC is C+1) ),
	valid_pos(NewC,NewL),
	/* effects */
	change_map(M,C,L,0,M1),
	change_map(M1,NewC,NewL,r,NewM),
	retract(map(M)),
	assert(map(NewM)).

/*--------------------------------------*/
/* Actions small Library		*/
/*--------------------------------------*/
valid_pos(C,L) :- 
	C>=1,C=<5,L>=1,L=<4,
	map(M),
	map_pos(M,C,L,0).

/*--------------------------------------*/
/* Library 				*/
/*--------------------------------------*/

/*--------------------------------------*/
/* nth_element(L,N,E)			*/
/* input : L, N, output : E		*/
/* ?- nth_element([a,b,c,f,g],3,X).	*/
/* X=c					*/
/*--------------------------------------*/
nth_element([X|Xs],1,X).
nth_element([A|Xs],N,X) :-
	M is N-1, nth_element(Xs,M,X).
	
/*--------------------------------------*/
/* map_element(Map,C,L,E)		*/
/* input : Map,C,L, output : E		*/
/* ?- map_element([[a,b],[c,d],[e,f]],2,3,X).	*/
/* X=f					*/
/*--------------------------------------*/
map_element(Map,C,L,X) :-
	nth_element(Map,L,Line),
	nth_element(Line,C,X).

/*--------------------------------------*/
/* element_pos(L,N,E)			*/
/* input : L, E, output : N		*/
/* ?- element_pos([a,b,c,f,g],N,c).	*/
/* N=3					*/
/*--------------------------------------*/
element_pos([X|Xs],1,X).
element_pos([A|Xs],N,X) :-
	element_pos(Xs,M,X), N is M+1.
	
/*--------------------------------------*/
/* map_pos(Map,C,L,E)			*/
/* input : Map,E, output : C,L		*/
/* ?- map_pos([[a,b],[c,d],[e,f]],C,L,f).*/
/* C=2					*/
/* L=3					*/
/*--------------------------------------*/
map_pos(Map,C,L,X) :-
	element_pos(Map,L,Line),
	element_pos(Line,C,X).

/*--------------------------------------*/
/* change_list(List,N,E,List1)		*/
/* input : List,N,E, output : List1	*/
/* ?- change_list([a,b,c,d],3,k,List).	*/
/* List=[a,b,k,d]			*/
/*--------------------------------------*/
change_list([X|Xs],1,Y,[Y|Xs]).
change_list([A|Xs],N,X,[A|Ys]) :-
	M is N-1, change_list(Xs,M,X,Ys).

/*--------------------------------------*/
/* change_map(Map,C,L,E,NewMap)		*/
/* input : Map,C,L,E, output : NewMap	*/
/* ?- change_map([[a,b],[c,d],[e,f]],2,3,k,M).	*/
/* M=[[a,b],[c,d],[e,k]]		*/
/*--------------------------------------*/
change_map(Map,C,L,E,Map1) :-
	nth_element(Map,L,Line),
	change_list(Line,C,E,Line1),
	change_list(Map,L,Line1,Map1).

/*--------------------------------------*/
/* ifthen(C,E)				*/
/* input : C,E 				*/
/* if C true then run E			*/
/* ?- ifthen(3>2,write('ok')).		*/
/*--------------------------------------*/
ifthen(C,E) :- call(C), !, call(E).
ifthen(C,E).

/*--------------------------------------*/
/* ifthenelse(C,E1,E2)			*/
/* input : C,E1,E2			*/
/* if C true then run E1 else run E2	*/
/* ?- ifthenelse(3>2,write('ok'),write('not ok')).	*/
/*--------------------------------------*/
ifthenelse(C,E1,E2) :- call(C), !, call(E1).
ifthenelse(C,E1,E2) :- call(E2).



























