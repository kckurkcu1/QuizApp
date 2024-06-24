class QuizProgram
{
    static void Main()
    {
        // Sorular
        string[] questions =
        {
            "Almanya'nın başkenti neresidir ?",
            "TBMM ilk olarak hangi yıl açılmıştır ?",
            "Savaş ve Barış isimli romanın yazarı kimdir ?",
            "En küçük atomik partikül nedir ?",
            "Mona Lisa tablosunun sanatçısı kimdir ?"
        };

        // Cevaplar
        string[] answers =
        {
            "A. Helsinki \nB. Berlin \nC. Kopenhag",
            "A. 1923 \nB. 1920 \nC. 1918",
            "A. Lev Tolstoy \nB. Fyodor Dostoyevski \nC. Victor Hugo",
            "A. Proton \nB. Nötron \nC. Kuark",
            "A. Michelangelo \nB. Pablo Picasso \nC. Leonardo da Vinci"
        };

        int[] correctAnswers = { 1, 1, 0, 2, 2 };
        int playerScore = 0;

        Console.WriteLine("Quiz Uygulamasına Hoş geldiniz !");
        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine("\nSoru " + (i + 1));
            Console.WriteLine(questions[i]);
            Console.WriteLine(answers[i]);
            Console.Write("Lütfen cevabınızı giriniz. ('A','B', veya 'C'): ");
            string playerAnswer = Console.ReadLine();

            // Cevapları Doğrulama
            if (string.Equals(playerAnswer, "A", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 0)
            {
                playerScore++;
            }
            else if (string.Equals(playerAnswer, "B", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 1)
            {
                playerScore++;
            }
            else if (string.Equals(playerAnswer, "C", StringComparison.OrdinalIgnoreCase) && correctAnswers[i] == 2)
            {
                playerScore++;
            }
        
        
        
        
        }

        // Kullanıcıya Skor Bildirimi
        Console.WriteLine("Quiz Tamamlandı !");
        Console.WriteLine("Puanınız : " + playerScore + "/" + questions.Length);
        Console.ReadKey();

    }
}