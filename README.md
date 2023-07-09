<h1 align="center"> Jogo da Forca </h1>

> ![Static Badge](https://img.shields.io/badge/status-finalizado-blue)  
> Atividade da Academia do Programador  
> Programado em inglês no Windows Forms  
> Feito por Paola Oliveira em 14/05/2023

<br>

## Sobre

Apresento o antigo e famoso 'jogo da forca', agora em inglês e com uma temática baseada no jogo <a href="https://www.crazygames.com/t/henry-stickmin">'Henry Stickmin'</a>. 
A aplicação é acompanhada de ilustrações desenhadas à mão, que complementam a experiência. 
Todas as palavras secretas são em inglês e fazem parte do universo da temática escolhida.

<br>

## Funcionalidades

- Escolhe aleatóriamente uma palavra secreta para ser adivinhada
- Permite escrever nos campos de letras pelo teclado da tela
- Retorna um feedback a cada letra escolhida, sendo:
  - `Vermelho`: a palavra não contém essa letra;
  - `Verde`: a letra está presente na palavra e mostra a sua posição.
- Permite que o jogador erre até sete vezes antes de encerrar o jogo
- Possibilita jogar quantas vezes quiser com o botão Reset

<br>

## Como executar 

*Pré-requisitos:* <a title="página da microsoft dotnet" href="https://dotnet.microsoft.com/download"> dotnet 6.0 </a> e <a title="página do git" href="https://git-scm.com/"> Git </a>  
*Onde executar:* Prompt de comando ou Git Bash

```Shell
# clonar repositório
git clone https://github.com/apaolaoliveira/HangmanWinForms

# entrar na pasta executável 
cd HangmanWinForms/HangmanWinForms

# compilar o projeto
dotnet build

# executar a aplicação
dotnet run
```

<br>

## Tecnologias e Ferramentas
 
 `C#` `Visual Studio` `Procreate`
