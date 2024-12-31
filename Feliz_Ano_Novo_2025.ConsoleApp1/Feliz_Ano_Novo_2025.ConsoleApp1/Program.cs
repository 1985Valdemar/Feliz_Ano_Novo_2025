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

    // Exibe animação da mensagem com efeitos de cores e centraliza no meio da tela
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
                Thread.Sleep(1200); // Tempo entre mensagens
            }

            Thread.Sleep(3000); // Pausa entre ciclos completos
        }
    }

    // Centraliza o texto no meio da tela
    static void CenterText(string text)
    {
        int windowWidth = Console.WindowWidth;
        int textLength = text.Length;
        int spaces = (windowWidth - textLength) / 2;
        Console.WriteLine(new string(' ', spaces) + text);
    }

    // Exibe contagem regressiva com efeitos visuais
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
        Thread.Sleep(2000); // Pausa para destacar a mensagem final
    }

    // Reproduz música de fundo se disponível
    static void PlayMusic(string musicPath)
    {
        try
        {
            if (File.Exists(musicPath))
            {
                using (SoundPlayer player = new SoundPlayer(musicPath))
                {
                    player.PlayLooping(); // Tocar música em loop
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
        // Configurar a codificação UTF-8 para suporte a emojis
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string musicPath = @"C:\Users\Acer\Documents\0.0 - C#_Curso\Feliz_2025\Feliz_Ano_Novo_2025.ConsoleApp1\Feliz_Ano_Novo_2025.ConsoleApp1\music\2025.wav";

        // Reproduz música em segundo plano
        Thread musicThread = new Thread(() => PlayMusic(musicPath));
        musicThread.Start();

        // Realiza a contagem regressiva
        Countdown();

        // Exibe mensagens animadas
        DisplayMessage();
    }
}
