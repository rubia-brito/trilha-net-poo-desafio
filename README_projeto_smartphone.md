# 📱 Sistema de Smartphones

Projeto desenvolvido para praticar **Programação Orientada a Objetos**
utilizando **C# e .NET**.

Este projeto foi desenvolvido durante os estudos na plataforma **Digital
Innovation One (DIO)**.

## 🎯 Objetivo

Aplicar conceitos fundamentais de Programação Orientada a Objetos.

## 🧠 Conceitos aplicados

-   Abstração
-   Herança
-   Polimorfismo
-   Classes abstratas
-   Construtores
-   Sobrescrita de métodos (`override`)

## 🧩 Estrutura do Projeto

    ProjetoSmartphone
     ┣ Models
     ┃ ┣ Smartphone.cs
     ┃ ┣ Nokia.cs
     ┃ ┗ Iphone.cs
     ┣ ProjetoSmartphone.csproj
     ┣ Program.cs
     ┗ README.md

## 📱 Funcionamento

O projeto simula dois tipos de smartphones:

-   **Nokia**
-   **Iphone**

Ambos herdam da classe abstrata **Smartphone**, que define
comportamentos básicos como:

-   Ligar
-   Receber ligação
-   Instalar aplicativo

Cada smartphone implementa seu próprio comportamento para instalação de
aplicativos.

## ▶️ Exemplo de saída no terminal

    === Teste Nokia ===
    Ligando...
    Recebendo ligação...
    Instalando WhatsApp na Play Store/Android...

    === Teste Iphone ===
    Ligando...
    Recebendo ligação...
    Instalando Instagram na App Store/IOS...

## 🚀 Tecnologias utilizadas

-   C#
-   .NET
-   Programação Orientada a Objetos
