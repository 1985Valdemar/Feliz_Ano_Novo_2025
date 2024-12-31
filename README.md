<h1 align="center"> 🎉 Feliz Ano Novo 2025! 🎆 </h1>

<p align="center"> <img src="https://img.shields.io/badge/Status-Em%20Desenvolvimento-orange" alt="Status" /> <img src="https://img.shields.io/badge/Versão-1.0.0-blue" alt="Versão" /> </p>

## 🛠️ Projeto de Contagem Regressiva para 2025
## 🚀 Celebração do Ano Novo com C# e Visual Studio!
<p align="center"> <a href="#sobre">Sobre</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp; <a href="#exemplo-de-código">Exemplo de Código</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp; <a href="#tecnologias-utilizadas">Tecnologias Utilizadas</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp; <a href="#autores">Autores</a> </p>

## 📖 Sobre
Este projeto é um pequeno programa em C# que exibe uma contagem regressiva para o Ano Novo de 2025, seguida de uma mensagem animada e música de fundo. O objetivo é proporcionar uma celebração divertida e interativa para dar boas-vindas ao novo ano.


## 💻 Exemplo de Código
```C#
using System;
using System.IO;
using System.Media;
using System.Threading;

class Program
{
    static ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Yellow, ConsoleColor.Cyan, ConsoleColor.Magenta };

    static string[] messages =
    {
        "🌟🌟🌟🌟 Feliz 2025! 🎉🎉🎉🎉",
        "🎊🎊🎊 Que seu ano novo seja repleto",
        "✨✨✨✨ de muita alegria, sucesso,",
        "🚀🚀🚀🚀 e muito código C#! 🚀🚀🚀🚀"
    };

    const string border = "**********************************";

    static void DisplayMessage()
    {
        int colorIndex = 0;

        while (true)
        {
            Console.Clear();
            Console.WriteLine();

            foreach (var message in messages)
            {
                Console.ForegroundColor = colors[colorIndex];
                CenterText(border);
                CenterText($" {message} ");
                CenterText(border);
                colorIndex = (colorIndex + 1) % colors.Length;
                Thread.Sleep(1200);
            }

            Thread.Sleep(3000);
        }
    }

    static void CenterText(string text)
    {
        int windowWidth = Console.WindowWidth;
        int textLength = text.Length;
        int spaces = (windowWidth - textLength) / 2;
        Console.WriteLine(new string(' ', spaces) + text);
    }

    static void Countdown()
    {
        Console.Clear();
        Console.WriteLine("🎆🎇🎇 Contagem regressiva para 2025! 🎇🎇🎇");

        for (int i = 10; i >= 0; i--)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            CenterText($"💥 {i}");
            Thread.Sleep(1000);

            if (i > 0)
            {
                Console.Clear();
            }
        }

        CenterText("🎉🎉🎉🎉 Feliz Ano Novo! 🎉🎉🎉🎉");
        Thread.Sleep(2000);
    }

    static void PlayMusic(string musicPath)
    {
        try
        {
            if (File.Exists(musicPath))
            {
                using (SoundPlayer player = new SoundPlayer(musicPath))
                {
                    player.PlayLooping();
                }
            }
            else
            {
                Console.WriteLine($"⚠️ Aviso: Arquivo de música não encontrado em '{musicPath}'.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro ao reproduzir música: {ex.Message}");
        }
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string musicPath = @"C:\Users\Acer\Documents\0.0 - C#_Curso\Feliz_2025\Feliz_Ano_Novo_2025\Feliz_Ano_Novo_2025.ConsoleApp1\Feliz_Ano_Novo_2025.ConsoleApp1\music\2025.wav";

        Thread musicThread = new Thread(() => PlayMusic(musicPath));
        musicThread.Start();

        Countdown();
        DisplayMessage();
    }
}

```
## 🛠️ Imagem codigo:
![Captura de tela 2024-12-31 071123](https://github.com/user-attachments/assets/d8b9035e-c3b4-494b-9c8f-fa8ed3d9db7e)

![Captura de tela 2024-12-31 071129](https://github.com/user-attachments/assets/b19a616c-42f0-4872-9fe6-f6d49ad0ea6d)


![Captura de tela 2024-12-31 071056](https://github.com/user-attachments/assets/3bd1d7cb-65dc-48aa-affb-dd3c7aa0bbc4)




## 🛠️ Tecnologias Utilizadas

Este projeto foi desenvolvido com as seguintes tecnologias:

- **IDE**: [Visual Studio](https://visualstudio.microsoft.com/)
- **Controle de Versão**: [Git](https://git-scm.com/) e [GitHub](https://github.com/)
- **Linguagem**: [C#](https://learn.microsoft.com/dotnet/csharp/)
- **Manipulando Icones**:  Console.OutputEncoding = System.Text.Encoding.UTF8; .
- **Manipulação de Musicas** using (SoundPlayer player = new SoundPlayer(musicPath)) .
  
---
✍️ Autores
- Valdemar
