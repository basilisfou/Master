/*----------------------------------------------*/
/*			Planner			*/
/*----------------------------------------------*/


/*----------------------------------------------*/
/*			Cube example		*/
/*----------------------------------------------*/
/* start/1 :Current State of the World		*/
/* goal/1 : Goal conditions			*/
/*----------------------------------------------*/
/*
maxdepth(20).
start([
	freecube(a),
	freecube(c),
	ontable(b),
	ontable(c),
	on(a,b)
]).
goal([on(c,b),on(b,a)]).
*/
/*----------------------------------------------*/
/*	Action Definition			*/
/*----------------------------------------------*/
/*
select_action(put_on_table(X), Win, Wout) :- 
	member(freecube(X),Win), 		% preconditions
	member(on(X,Y),Win),
	append([ontable(X),freecube(Y)],Win,W1), % add effects
	delete(W1,on(X,Y),Wout). 		% delete effects

select_action(put_on_cube(X,Y),Win,Wout) :- 
	member(freecube(X),Win), 		% preconditions
	member(freecube(Y),Win),
	X\=Y,
	member(ontable(X),Win),
	append([on(X,Y)],Win,W1),		% add effects
	delete(W1,freecube(Y),W2),		% delete effects
	delete(W2,ontable(X),Wout).
*/

/*==============================================*/

/*----------------------------------------------*/
/*	Robot example				*/
/*----------------------------------------------*/
/* start/1 :Current State of the World		*/
/* goal/1 : Goal conditions			*/
/*----------------------------------------------*/
/*----------------------------------------------*/
/* start/1 :Current State of the World		*/
/* goal/1 : Goal conditions			*/
/*----------------------------------------------*/
maxdepth(20).
start([
	[0,0,0,1,r,1,0],
	[0,1,0,0,0,0,0],
	[0,1,0,0,0,1,0],
	[0,0,0,1,1,1,0]
]).
goal([
	[0,0,0,1,0,1,0],
	[0,1,0,0,0,0,0],
	[0,1,0,0,0,1,0],
	[0,0,r,1,1,1,0]]).
/*----------------------------------------------*/
/*	Action Definition			*/
/*----------------------------------------------*/
select_action(up, Mapin, Mapout) :- 
	map_pos(Mapin,Cr,Lr,r), 	% preconditions
	NLr is Lr-1,
	NLr>0, 
	cr_element(Mapin,Cr,NLr,0),
	change_map(Mapin,Map1,Cr,Lr,0),		%  effects
	change_map(Mapin,Map1,Cr,NLr,r). 	

select_action(down, Mapin, Mapout) :- 
	map_pos(Mapin,Cr,Lr,r), 	% preconditions
	length(Mapin,MaxL),
	NLr is Lr+1,
	NLr=<MaxL, 
	cr_element(Mapin,Cr,NLr,0),
	change_map(Mapin,Map1,Cr,Lr,0),		%  effects
	change_map(Map1,Mapout,Cr,NLr,r). 


/*----------------------------------------------*/
/*	Planner Kernel				*/
/*----------------------------------------------*/
/* ?- plan(Start,Goal,Plan)			*/

goplan(Plan) :- 
	start(S),
	goal(G),
	maxdepth(M),nl,
	plan(S,G,1,M,[],Plan).

/* plan(Win,Goal,MaxDepth,MaxDepth,_,[]). */
plan(Win,Goal,_,_,_,[]) :-
	subset(Goal,Win).
plan(Win,Goal,Depth,MaxDepth,Visited,[Action|Subplan]) :-
	select_action(Action,Win,W1),
	not(specialmember(W1,Visited)),
	NewDepth is Depth+1,
	NewDepth =< MaxDepth,
	write(NewDepth),write(' , '),
	plan(W1,Goal,NewDepth,MaxDepth,[W1|Visited],Subplan).

/*----------------------------------------------*/
/*	Library					*/
/*----------------------------------------------*/

subset([],_).
subset([H|T],X) :- member(H,X), subset(T,X).

equalset(X,Y) :- subset(X,Y),subset(Y,X).

specialmember(X,[Y|_]) :- 
	subset(X,Y).
specialmember(X,[_|Rest]) :- 
	specialmember(X,Rest).

/*----------------------------------------------*/
/*	Library	for robot			*/
/*----------------------------------------------*/
nth_element([H|T],1,H) :- !.
nth_element([H|T],N,A) :- M is N-1, nth_element(T,M,A).

element_pos([A|T],1,A).
element_pos([H|T],N,A) :- element_pos(T,M,A), N is M+1.

change_list([_|T],[A|T],1,A).
change_list([H|T],[H|NT],N,A) :-
	M is N-1, 
	change_list(T,NT,M,A).
/*----------------------------------------------*/

cr_element(Map, Column, Row, Element) :-
	nth_element(Map,Row,Line),
	nth_element(Line,Column,Element), !.

map_pos(Map, Column, Row, Element) :-
	element_pos(Map,Row,Line),
	element_pos(Line,Column,Element), !.

/* change_map(Map1, Map2, C, L, E) */
change_map([Line1|Map1],[Line2|Map1],C,1,E) :- 
	change_list(Line1,Line2,C,E).
change_map([Line1|Map1],[Line1|Map2],C,L,E) :- 
	NL is L-1,
	change_map(Map1,Map2,C,NL,E).

/*----------------------------------------------*/


