// ESB tarafından iletilen bir mesaj sınıfı
public class ESBMessage
{
    public string Content { get; set; }
}

// ESB'yi temsil eden karmaşık bir sınıf
public class EnterpriseServiceBus
{
    public void SendMessageWithTransformations(ESBMessage message)
    {
        // Veri dönüşümü ve güvenlik önlemleri uygulanır
        string transformedData = ApplyTransformations(message.Content);
        string encryptedData = ApplySecurity(transformedData);

        // İş süreci yönetimi eklenir
        string result = ManageBusinessProcess(encryptedData);

        // Sonuç, hedef sistem için uygun bir formata dönüştürülür
        string formattedResult = FormatForTargetSystem(result);

        // Hedef sisteme iletilir
        SendToTargetSystem(formattedResult);
    }

    // Veri dönüşümü işlevi
    private string ApplyTransformations(string data)
    {
        // Veri dönüşümü kodları burada olur
        return data.ToUpper();
    }

    // Güvenlik önlemleri işlevi
    private string ApplySecurity(string data)
    {
        // Güvenlik kodları burada olur
        return data + "_ENCRYPTED";
    }

    // İş süreci yönetimi işlevi
    private string ManageBusinessProcess(string data)
    {
        // İş süreci yönetimi kodları burada olur
        return data + "_PROCESSED";
    }

    // Hedef sisteme iletim işlevi
    private void SendToTargetSystem(string data)
    {
        // Hedef sisteme iletim kodları burada olur
        Console.WriteLine("ESB: Mesaj hedef sisteme iletiliyor - " + data);
    }

    // Hedef sisteme uygun biçimlendirme işlevi
    private string FormatForTargetSystem(string data)
    {
        // Biçimlendirme kodları burada olur
        return "<message>" + data + "</message>";
    }
}

class Program
{
    static void Main()
    {
        // ESB kullanarak sipariş verme ve stok güncelleme işlemleri
        var esb = new EnterpriseServiceBus();

        // Sipariş verme işlemi
        var orderMessage = new ESBMessage { Content = "Ürün A, 10 adet" };
        esb.SendMessageWithTransformations(orderMessage);

        // Stok güncelleme işlemi
        var stockMessage = new ESBMessage { Content = "Ürün A, 90 adet" };
        esb.SendMessageWithTransformations(stockMessage);

        Console.ReadLine();
    }
}
