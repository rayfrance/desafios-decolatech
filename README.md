# Desafios em C# - Decola Tech

Aqui você encontrará os desafios realizados no bootcamp Decola Tech da Avanade, oferecido pela Digital Innovation One.

<div align="center">
  <img height="180em" src="https://www.projetodraft.com/wp-content/uploads/2019/12/digital-innovation-one.jpg"/>
  <img height="180em" src="https://www.avanade.com/-/media/logo/share-avanade-logo.jpg?la=pt-br&ver=1"/>
</div>


## Desafio 1 - Xenlongão

Kogu está buscando as esferas do dragão para invocar Xenlongão e pedir para ele reviver seu amigo Kuriri, que infelizmente morreu de novo na última batalha dos guerreiros Zê.

Porém Kogu está tendo muita dificuldade para encontrar as esferas, por isso Xenlongão que é seu conhecido há muito tempo, decidiu abrir uma exceção e aceitou ser invocado caso 
Kogu encontre todas as esferas cujo o número de divisores da quantidade de estrelas da esfera sejam par.

Por exemplo se existem sete esferas, Kogu não precisaria encontrar as esferas de uma e quatro estrelas, pois elas tem uma quantidade ímpar de divisores, então ele só precisa
pegar 5 esferas para invocar Xenlongão.
/Como Kogu não é muito bom em contas, ele pediu para você escrever um programa que dado o total de esferas existentes, mostre a quantidade mínima de esferas que ele precisa 
procurar.

**Entrada**
A primeira linha consiste de um inteiro C que representa a quantidade de casos de teste. As linhas subsequentes contém um inteiro N (2 ≤ N ≤ 109) que representa a quantidade
de esferas necessárias para invocar Xenlongão.

**Saída**
Seu programa deve exibir a quantidade mínima de esferas que Kogu tem que procurar.

## Desafio 2 - Quadrado de pares

Leia um valor inteiro N. Apresente o quadrado de cada um dos valores pares, de 1 até N, inclusive N, se for o caso.

**Entrada**
A entrada contém um valor inteiro N (5 < N < 2000).

##Saída
Imprima o quadrado de cada um dos valores pares, de 1 até N, conforme o exemplo abaixo.

Tome cuidado! Algumas linguagens tem por padrão apresentarem como saída 1e+006 ao invés de 1000000 o que ocasionará resposta errada.
Neste caso, configure a precisão adequadamente para que isso não ocorra.

## Desafio 3 - Sequência S

Escreva um algoritmo para calcular e escrever o valor de S, sendo S dado pela fórmula:
S = 1 + 1/2 + 1/3 + … + 1/100

**Entrada**
Não há nenhuma entrada neste problema.

**Saída**
A saída contém um valor correspondente ao valor de S.
O valor deve ser impresso com dois dígitos após o ponto decimal.

## Desafio 4 - Sequência ij

Você deve fazer um programa que apresente a sequencia conforme o exemplo abaixo.

**Entrada**
Não há nenhuma entrada neste problema.

**Saída**
Imprima a sequencia conforme exemplo abaixo

**Exemplo de Saída**
 	
I=1 J=7
I=1 J=6
I=1 J=5
I=3 J=7
I=3 J=6
I=3 J=5
...
I=9 J=7
I=9 J=6
I=9 J=5

## Desafio 5 - Vai ter copa

Kluper é o país sede da copa do mundo. Porém, há muitas pessoas protestando contra o governo. Em redes sociais é possível ver pessoas afirmando 
que não vai ter copa devido aos protestos e insatisfação política

Mas esses rumores de que não haverá copa são totalmente falsos, e o governo já avisou: vai ter copa sim! 

**Entrada**
A entrada contém vários casos de teste. Cada caso de teste consiste de uma linha contendo o número N de reclamações sobre a copa encaminhadas 
para o governo (0 ≤ N ≤ 100).

**Saída**
Para cada teste, a saída consiste de uma linha dizendo "vai ter copa!" caso não haja reclamações para o governo. Caso haja reclamações, a saída
deverá dizer "vai ter duas!".