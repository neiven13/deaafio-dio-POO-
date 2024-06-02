using desafio_POO_smartphone.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Nokia:");
try
{
    Smartphone celular = new Nokia("62985858585","2780 Flip","iiiiiiiii",8);
    celular.InstalApp("Whatsapp");
    celular.MakeACall();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine("\nIphone:");
try
{
    Smartphone celular = new Iphone("64955858585","15","iiiiiiiii",256);
    celular.InstalApp("Notion");
    celular.IncomingCall();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}