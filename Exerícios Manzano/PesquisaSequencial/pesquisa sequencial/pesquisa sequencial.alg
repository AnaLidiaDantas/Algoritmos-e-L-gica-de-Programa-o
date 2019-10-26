algoritmo "PesquisaSequencial"

var
   num: vetor[1..10] de inteiro
   i, pesq: inteiro
   acha: logico
   resp: caracter

inicio

   para i de 1 ate 10 faca
      escreva("Digite um numero: ")
      leia(num[i])
   fimpara
   resp <- "sim"
   enquanto (resp = "sim") faca
      escreva("Entre o nome a ser pesquisado: ")
      leia(pesq)

      i<-1
      acha<-falso
      enquanto (i<=10) e (acha=falso) faca
         se(pesq=num[i])entao
            acha<-verdadeiro
         senao
            i<-i+1
         fimse
      fimenquanto
      se(acha=verdadeiro)entao
         escreval(pesq, "foi localizado na posição ", i)
      senao
         escreval(pesq, " não foi localizado")
      fimse
      escreva("Deseja continuar?[sim/nao] ")
      leia(resp)
   fimenquanto
fimalgoritmo
