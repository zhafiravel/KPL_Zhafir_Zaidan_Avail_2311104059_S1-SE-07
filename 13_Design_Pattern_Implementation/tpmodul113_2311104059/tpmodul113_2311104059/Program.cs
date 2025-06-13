using System;

class Program
{
    static void Main(string[] args)
    {
        // Membuat Subject
        NewsAgency newsAgency = new NewsAgency();

        // Membuat Observers
        EmailSubscriber email = new EmailSubscriber("Zhafir");
        SmsSubscriber sms = new SmsSubscriber("Rafi");

        // Menambahkan Observer ke Subject
        newsAgency.Attach(email);
        newsAgency.Attach(sms);

        // Mengirim berita
        newsAgency.PublishNews("Banjir besar di Bandung!");
        newsAgency.PublishNews("Harga BBM naik per Juni!");

        // Menghapus salah satu subscriber
        newsAgency.Detach(email);

        // Berita ketiga, hanya SMS yang terima
        newsAgency.PublishNews("Gempa bumi terasa di Jakarta");
    }
}
