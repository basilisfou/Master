/*----------------------------------------------*/
/*			Planner			*/
/*----------------------------------------------*/

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
maxdepth(100).
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
select_action(north, Mapin, Mapout) :- 
	map_pos(Mapin,Cr,Lr,r), 	% preconditions
	NLr is Lr-1,
	NLr>0, 
	cr_element(Mapin,Cr,NLr,0),
	change_map(Mapin,Map1,Cr,Lr,0),		%  effects
	change_map(Map1,Mapout,Cr,NLr,r). 	

select_action(south, Mapin, Mapout) :- 
	map_pos(Mapin,Cr,Lr,r), 	% preconditions
	length(Mapin,MaxL),
	NLr is Lr+1,
	NLr=<MaxL, 
	cr_element(Mapin,Cr,NLr,0),
	change_map(Mapin,Map1,Cr,Lr,0),		%  effects
	change_map(Map1,Mapout,Cr,NLr,r). 

select_action(west, Mapin, Mapout) :- 
	map_pos(Mapin,Cr,Lr,r), 	% preconditions
	NCr is Cr-1,
	NCr>0, 
	cr_element(Mapin,NCr,Lr,0),
	change_map(Mapin,Map1,Cr,Lr,0),		%  effects
	change_map(Map1,Mapout,NCr,Lr,r). 	

select_action(east, Mapin, Mapout) :- 
	map_pos(Mapin,Cr,Lr,r), 	% preconditions
	Mapin=[Line|_],
	length(Line,MaxC),
	NCr is Cr+1,
	NCr=<MaxC, 
	cr_element(Mapin,NCr,Lr,0),
	change_map(Mapin,Map1,Cr,Lr,0),		%  effects
	change_map(Map1,Mapout,NCr,Lr,r). 

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
plan(Win,Win,_,_,_,[]).
plan(Win,Goal,Depth,MaxDepth,Visited,[Action|Subplan]) :-
	select_action(Action,Win,W1),
	not(member(W1,Visited)),
	NewDepth is Depth+1,
	NewDepth =< MaxDepth,
	write(Action),write(' , '),
	write(NewDepth),write(' , '),nl,
	nicewrite(W1),nl,
	plan(W1,Goal,NewDepth,MaxDepth,[W1|Visited],Subplan).

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

nicewrite([]):-nl.
nicewrite([X|Xs]) :- write(X),nl,nicewrite(Xs).

