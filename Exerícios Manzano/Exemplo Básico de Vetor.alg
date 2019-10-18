algoritmo "semnome"
// Função :
// Autor :
// Data : 20/09/2019
// Seção de Declarações
var
md: vetor[1..8] de real
soma, media: real
i: inteiro

inicio
soma<-0
para i de 1 ate 8 passo 1 faca
   escreva("Digite a ", i, "ª nota: ")
   leia(md[i])
   soma<-soma+md[i]
fimpara
media<-soma/8
escreva ("A média dos alunos foi ", media)
fimalgoritmo
