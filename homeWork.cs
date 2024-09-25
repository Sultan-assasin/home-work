//1 dry
public void printLog(string message, string warning){
    if(warning== "Warning"){
        Console.WriteLine($"WARNING: {message}");
    }
    if(warning=="ERROR"){
        Console.WriteLine($"ERROR: {message}");
    }
    if(warning=="INFO"){
            Console.WriteLine($"INFO: {message}");
    }
}

//3 kiss  java
public void processNumbers(int[] numbers) {
    if (numbers == null || numbers.length == 0) {
        return;
    }

    // Использование обычного цикла for с индексом
    for (int i = 0; i < numbers.length; i++) {
        if (numbers[i] > 0) {
            System.out.println(numbers[i]);
        }
    }
}

//4 

public void PrintPositiveNumbers(int[] numbers)
{
    if (numbers == null)
    {
        return;
    }

    // Итерируем массив и сразу выводим положительные числа
    foreach (var number in numbers)
    {
        if (number > 0)
        {
            Console.WriteLine(number);
        }
    }
}

//5 

public void divide(int a, int b){
    if(a>0 || b>0){
        return a/b;
    }
    return 0;
}


//6 
public class User
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
}
public class SaveToDatabase{
    public void SaveToDatabase()
        {
        // Код для сохранения пользователя в базу данных
        }
}

public class SendEmail 
{
     public void SendEmail()
    {
        // Код для отправки электронного письма пользователю
    }
}

public class PrintAddressLabel
{
    public void PrintAddressLabel()
    {
        // Код для печати адресного ярлыка
    }
}

//7

public class FileReader
{
    public string ReadFile(string filePath, bool useBuffer = true, int bufferSize = 1024)
    {
        // Логика чтения файла с возможностью использования буфера
        if (useBuffer)
        {
            // Чтение с буфером
        }
        if(bufferSize <=1024){
            //чтение данных равно или меньше 1024
        }
        else{
            //чтение данных больше 1024
        }
        else
        {
            // Чтение без буфера
        }
        return "file content";
    }
}

//8
public class ReportGenerator
{
    public void GeneratePdfReport()
    {
        // Генерация PDF отчета
        public void GeneratePdfReportCreated()
        sendToEmail()
    }

    public void GenerateExcelReport()
    {
        // Генерация Excel отчета
         public void GenerateExcelReportCreated()
         sendToEmail()
    }

    public void GenerateHtmlReport()
    {
        // Генерация HTML отчета
        public void GeneratePdfReportCreated()
        sendToEmail()
    }

     public void sendToEmail(string toAddress,string fromAddress){
        // отправить в почту 
        MailAddress to = new MailAddress(toAddress);
        MailAddress from = new MailAddress(fromAddress);

        MailMessage email = new MailMessage(from, to);
        email.Subject = "Testing out email sending";
        email.Body = "Hello all the way from the land of C#";

        SmtpClient smtp = new SmtpClient();
        smtp.Host = "smtp.server.address";
        smtp.Port = 25;
        smtp.Credentials = new NetworkCredential("smtp_username", "smtp_password");
        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
        smtp.EnableSsl = true;

        try
        {
            /* Send method called below is what will send off our email 
            * unless an exception is thrown.
            */ 
            smtp.Send(email);
        }
        catch (SmtpException ex)
        {
            Console.WriteLine(ex.ToString());
        }
     }

}



