direita(maria, joao).
esquerda(iris, joao).
direita(jose, maria).
esquerda(joao, maria).
direita(julia, jose).
esquerda(maria, jose).
direita(jorge, julia).
esquerda(jose, julia).
direita(ana, jorge).
esquerda(julia, jorge).
direita(iris, ana).
esquerda(jorge, ana).
direita(joao, iris).
esquerda(ana, iris).

vizinho(X, Y, Z):-
    direita(X, Z),
    esquerda(Y, Z);
    direita(Y, Z),
    esquerda(X, Z).

vizinhoAdjacente(X, Y) :-
    direita(X, Y);
    esquerda(X, Y);
    direita(Y, X);
    esquerda(Y, X).
