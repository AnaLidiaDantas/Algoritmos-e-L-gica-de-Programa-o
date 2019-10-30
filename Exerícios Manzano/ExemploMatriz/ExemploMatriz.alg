algoritmo "ExemploMatriz"

var
notas:vetor[1..8,1..4] de real
i, j:inteiro
inicio

para i de 1 ate 8 faca
   para j de 1 ate 4 faca
      escreva("Digite a ", i, "-",j,"nota: ")
      leia(notas[i,j])
   fimpara
fimpara

para i de 1 ate 8 faca
   para j de 1 ate 4 faca
      escreval("Nota[",i,",",j,"]=",notas[i,j])
   fimpara
fimpara

fimalgoritmo
