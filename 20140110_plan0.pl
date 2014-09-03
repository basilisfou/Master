/*----------------------------------------------*/
/*			Planner			*/
/*----------------------------------------------*/

maxdepth(20).

/*----------------------------------------------*/
/*	Current State of the World		*/
/*----------------------------------------------*/
start([
	freecube(a),
	freecube(c),
	ontable(b),
	ontable(c),
	on(a,b)
]).

/*----------------------------------------------*/
/*	Goal State of the World		*/
/*----------------------------------------------*/
goal([on(c,b),on(b,a)]).

/*----------------------------------------------*/
/*	Action Definition			*/
/*----------------------------------------------*/
select_action(put_on_table(X), Win, Wout) :- 
	/* preconditions */
	member(freecube(X),Win),
	member(on(X,Y),Win),
	/* effects */
	/* add : */
	append([ontable(X),freecube(Y)],Win,W1),
	/* delete : */
	delete(W1,on(X,Y),Wout).

select_action(put_on_cube(X,Y),Win,Wout) :- 
	/* preconditions */
	member(freecube(X),Win),
	member(freecube(Y),Win),
	X\=Y,
	member(ontable(X),Win),
	/* effects */
	/* add : */
	append([on(X,Y)],Win,W1),
	/* delete : */
	delete(W1,freecube(Y),W2),
	delete(W2,ontable(X),Wout).

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

















	











