algoritmo "semnome"
//página88
//corrigir
var
nome: vetor[1..10] de inteiro
i, j, comeco, final, meio: inteiro
pesq, resp, x: literal
acha:logico
inicio

para 1 de 1 ate 10 faca
leia(nome[i])
fimpara

//ordenação
para 1 de 1 ate 9 faca
para j de i+1 ate 10 faca
se (nome[i]>nome[j]) entao
x<-nome[i]
nome[i]<-nome[j]
nome[j]<-x
fimse
fimpara
fimpara

//mostra registros ordenados
para 1 de 1 ate 10 faca
escreval("nome[",1,"] - ",nome[i]
fimpara

//pesquisa
resp<-"sim"
enquanto (resp="sim") faca
escreva("Entre com o nome a ser pesquisado: ")
leia(pesq)
comeco<-1
final<-10
acha<-falso
enquanto (comeco<=final) e (acha=falso) faca
meio<-(comeco+final) div 2
se (pesq=nome[meio]) entao
acha<- verdadeiro
senao
se(pesq<nome[meio]) entao
final<-meio-1
senao<-meio+1
fimse
fimse
fimenquanto

se (acha=verdadeiro) entao
escreval (pesq, " foi localizado na posição ", meio)
senao
escreval(pesq, " não foi localizado")
fimse
escreva ("Deseja continuar? [sim/não] ")
leia (resp)
fimenquanto
fimalgoritmo

fimalgoritmo
