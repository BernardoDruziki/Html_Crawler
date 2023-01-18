using HtmlAgilityPack;			
public class Program
{
	public static void Main()
	{
		var urlSite = @"https://html-agility-pack.net/";//Url do site pro crawler varrer.

        HtmlWeb htmlSite = new HtmlWeb();//pega o HTML pelo HTTP.

        var htmlLoad = htmlSite.Load(urlSite);//Carrega o documento html.

        var crawlerAction = htmlLoad.DocumentNode.SelectSingleNode("//body");//DocumentNode - pega o 'node' inteiro //selectSingleNode - Seleciona o primeiro 'node' atribuido .

        Console.WriteLine(" Action: " + crawlerAction.Name + "\n" + crawlerAction.OuterHtml);//outerHtml- obtém o HTML do 'node', com tags de abertura e fechamento.
    }
}
