using System;
using System.Collections.Generic;


public class Itens
{
    public string Nome;
    public int Identificador;
    public int Preco;
    public string Detalhes;
}


public class Jogador
{
    public string Nome;
    public int Xp;
    public int Ouro;
    public List<Itens> Itens = new List<Itens>();
}


public class Trabalho
{
    static List<Jogador> Jogadores = new List<Jogador>();

    public static void Main(string[] args)
    {
        bool Menu = true;
        while (Menu)
        {
            Menu = MenuPrincipal();
        }
    }


    private static bool MenuPrincipal()
    {

            Itens Punhal_Do_Louco = new Itens();
            Punhal_Do_Louco.Identificador = 1;
            Punhal_Do_Louco.Nome = "Punhal do Louco";
            Punhal_Do_Louco.Preco = 90;
            Punhal_Do_Louco.Detalhes = "O Punhal que uma vez pertenceu a um Serial Killer usuário de magia elétrica(+30% DE DANO ELÉTRICO)";

            Itens Manoplas_Do_Dragão = new Itens();
            Manoplas_Do_Dragão.Identificador = 2;
            Manoplas_Do_Dragão.Nome = "Manoplas do Dragão";
            Manoplas_Do_Dragão.Preco = 300;
            Manoplas_Do_Dragão.Detalhes = "Essas manoplas foram criadas a partir de escamas do lendário dragão de fogo Falkor(+70% DE DANO DE FOGO)";

            Itens Cetro_De_Rá = new Itens();
            Cetro_De_Rá.Identificador = 3;
            Cetro_De_Rá.Nome = "Cetro de Rá";
            Cetro_De_Rá.Preco = 400;
            Cetro_De_Rá.Detalhes = "Um Cetro egípcio que muito antigo, com hieróglifos talhados, dizem que uma vez pertenceu a Rá, o Deus Egípcio do Sol(+50% NA VELOCIDADE DE CONJURAÇÃO)";

            Itens Lemegeton = new Itens();
            Lemegeton.Identificador = 4;
            Lemegeton.Nome = "Lemegeton";
            Lemegeton.Preco = 350;
            Lemegeton.Detalhes = "Também conhecido como 'A Chave Menor de Salomão' esse Grimório possui o conhecimento de invocação demoníaca do Rei Salomão(+50% DE CHANCE DE INVOCAR UM DEMÔNIO DE CLASSIFICAÇÃO ALEATÓRIA AO MATAR UM INIMIGO)";

            Itens Espada_Matadora_De_Deuses = new Itens();
            Espada_Matadora_De_Deuses.Identificador = 5;
            Espada_Matadora_De_Deuses.Nome = "Espada Matadora de Deuses";
            Espada_Matadora_De_Deuses.Preco = 1000;
            Espada_Matadora_De_Deuses.Detalhes = "Espada usada por um semideus grego para derrubar o Olimpus em uma vingança com os Titãs(20% DE CHANCE DE MATAR INSTANTANEAMENTE QUALQUER MONSTRO)";

            Itens Lâminas_Do_Caos = new Itens();
            Lâminas_Do_Caos.Identificador = 6;
            Lâminas_Do_Caos.Nome = "Lâminas do Caos";
            Lâminas_Do_Caos.Preco = 700;
            Lâminas_Do_Caos.Detalhes = "Arma concedida a um mortal pelo deus da guerra Áres(+70% DE BÔNUS DE DANO QUANDO A VIDA ESTIVER ABAIXO DE 80%)";

            Itens Lanche_Da_Mamãe = new Itens();
            Lanche_Da_Mamãe.Identificador = 7;
            Lanche_Da_Mamãe.Nome = "Lanche da Mamãe";
            Lanche_Da_Mamãe.Preco = 10000;
            Lanche_Da_Mamãe.Detalhes = "Esse lanche foi preparado pelas graciosas mãos da mamãe, e feito com muito carinho S2(+200% DE BÔNUS EM TODOS OS STATUS POR 48h)";


        Console.Clear();
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        Console.WriteLine("Digite '1' para criar um jogador (necessário para entrar na loja).");
        Console.WriteLine("Digite '2' para olhar as informações de todos os jogadores criados.");
        Console.WriteLine("Digite '3' para abrir o seu inventário.");
        Console.WriteLine("Digite '4' para acessar a loja.");
        Console.WriteLine("Digite '5' para encerrar o programa.");
        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        switch (Console.ReadLine())
        {


            case "1":

                Console.Clear();  
                
                Console.Write("Insira um Apelido: ");
                var JogaNome = Console.ReadLine();
                JogaNome = JogaNome.ToLower();


                Console.Write("Insira a quantidade de experiência ");
                var JogaXp = Console.ReadLine();
               
                Random GetEXP = new Random();
                var JogaOuro = GetEXP.Next(50, 3000);


                Jogadores.Add(new Jogador { Nome = JogaNome, Xp = Convert.ToInt32(JogaXp), Ouro = JogaOuro});
                Console.Clear();
                Console.WriteLine("Jogador criado com sucesso");
                Console.WriteLine("");
                Console.WriteLine("Foi adicionado $" + JogaOuro  + " de ouro na sua conta");
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.Read();
            return true;//FIM DO SWITCH CASE


            case "2":
                Console.Clear();
                for (int i = 0; i < Jogadores.Count; i++)
                {

                    Console.WriteLine("");
                    Console.WriteLine("Jogador:");            
                    Console.WriteLine("Apelido : " + Jogadores[i].Nome);
                    Console.WriteLine("Experiência : " + Jogadores[i].Xp);
                    Console.WriteLine("Ouro : " + Jogadores[i].Ouro);                 
                    Console.WriteLine("");
                }//FIM DO FOR

                Console.WriteLine("");
                Console.Write("Pressione qualquer tecla para sair...");
                Console.ReadKey();
            return true;//FIM DO SWITCH CASE
            

            case "3":
            Console.Clear();
            Console.WriteLine("Digite o apelido do jogador para abrir seu iventário:");
            var JogaNome0 = Console.ReadLine();
            JogaNome0 = JogaNome0.ToLower();
            foreach(Jogador p in Jogadores)
            {
                if(p.nome == JogaNome0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Itens:");
                    Console.WriteLine("");
                    for (int i = 0; i < p.Itens.Count; i++)
                    {
                        Console.WriteLine("Itens: " + p.Itens[i].Nome);
                    }//FIM DO FOR
                    Console.WriteLine("");
                    Console.WriteLine("Entre com qualquer tecla para continuar");
                    Console.Read();
                }//FIM DO IF
                else{
                    Console.Clear();
                    Console.WriteLine("Nenhum jogador encontrado... Voltando ao menu principal");
                    Console.Read();
                }//FIM DO ELSE
            }//FIM DO FOREACH
            return true;//FIM DO SWITCH CASE


            case "4":
            Console.Clear();
            Console.WriteLine("Digite o apelido do jogador que vai acessar a loja: ");
            JogaNome0 = Console.ReadLine();
            JogaNome0 = JogaNome0.ToLower();
            foreach(Jogador p in Jogadores)
            {
                if(p.Nome == JogaNome0)
                {       
                    Console.WriteLine("- Insira o ID do item que você quer comprar:");
                    Console.WriteLine("");
                    Console.WriteLine(Punhal_do_Louco.Identificador + " - " + Punhal_do_Louco.Nome  + " " + Punhal_do_Louco.Detalhes);
                    Console.WriteLine("");
                    Console.WriteLine(Manoplas_Do_Dragão.Identificador + " - " + Manoplas_Do_Dragão.Nome  + " " + Manoplas_Do_Dragão.Detalhes);
                    Console.WriteLine("");
                    Console.WriteLine(Cetro_De_Rá.Identificador + " - " + Cetro_De_Rá.Nome  + " " + Cetro_De_Rá.Detalhes);
                    Console.WriteLine("");
                    Console.WriteLine(Lemegeton.Identificador + " - " + Lemegeton.Nome  + " " + Lemegeton.Detalhes);
                    Console.WriteLine("");
                    Console.WriteLine(Espada_Matadora_De_Deuses.Identificador + " - " + Espada_Matadora_De_Deuses.Nome + " " + Espada_Matadora_De_Deuses.Detalhes);       
                    Console.WriteLine("");
                    Console.WriteLine(Lâminas_Do_Caos.Identificador + " - " + Lâminas_Do_Caos.Nome + " " + Lâminas_Do_Caos.Detalhes);       
                    Console.WriteLine("");
                    Console.WriteLine(Lanche_Da_Mamãe.Identificador + " - " + Lanche_Da_Mamãe.Nome + " " + Lanche_Da_Mamãe.Detalhes);       
                    Console.WriteLine("");
                    var ic = Console.ReadLine();
                 

                    if( ic == Punhal_Do_Louco.Identificador.ToString() ){

                        Console.WriteLine("Você gostaria de comprar " + Punhal_Do_Louco.Nome + " por " + Punhal_Do_Louco.Preco + "Ouros? (S)/(N)");
                        Console.WriteLine("Ouro no banco:" + p.Ouro);
                        var resp = Console.ReadLine();
                        if(resp == "s")
                        {
                            if(p.Ouro >= Punhal_Do_Louco.Preco)
                            {
                                p.Ouro = p.Ouro - Punhal_Do_Louco.Preco;
                                p.Itens.Add(Punhal_Do_Louco);
                                Console.Clear();
                                Console.WriteLine("Punhal do Louco comprado e adicionado ao inventário com sucesso!");
                                Console.WriteLine("Espero que não enlouqueça como o dono antigo ok?"); 
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }//FIM DO IF
                               else
                            {
                                Console.WriteLine("Hmm, parece que você não tem dinheiro suficiente hein..");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }//FIM DO ELSE
                        }//FIM DO IF
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }//FIM DO ELSE 
                    }//FIM DO ELSE IF


                    else if(ic == Manoplas_Do_Dragão.Identificador.ToString())
                    {
                        Console.WriteLine("Você gostaria de comprar " + Manoplas_Do_Dragão.Nome + " por " + Manoplas_Do_Dragão.Preco + "Ouros? (S)/(N)");
                        Console.WriteLine("Ouro no banco:" + p.Ouro);              
                         var resp = Console.ReadLine();
                        if(resp == "s")
                        {
                            if(p.Ouro >= Manoplas_Do_Dragão.Preco)
                            {
                                p.Ouro = p.Ouro - Manoplas_Do_Dragão.Preco;
                                p.Itens.Add(Manoplas_Do_Dragão);
                                Console.Clear();
                                Console.WriteLine("Manoplas do Dagrã-Digo, Manoplas do Dragrã-... Ah você sabe que foi comprado e adicionado ao inventário com sucesso!");
                                Console.WriteLine("Cuidado para não destruir essa manopla, quem criou isso choraria se soubesse disso."); 
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }//FIM DO IF
                            else
                            {
                                Console.WriteLine("Espera comprar essas manoplas só com isso? Acha que vou deixar?");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }//FIM DO ELSE
                        }//FIM DO IF
                              else{
                                Console.Clear();
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                           }//FIM DO ELSE 
                    }//FIM DO ELSE IF


                    else if(ic == Cetro_De_Rá.Identificador.ToString())
                    {

                       Console.WriteLine("Você gostaria de comprar " + Cetro_De_Rá.Nome + " por " + Cetro_De_Rá.Preco + "Ouros? (S)/(N)");
                       Console.WriteLine("Ouro no banco:" + p.Ouro);
                       var resp = Console.ReadLine();
                       resp = resp.ToLower();
                        if(resp == "s" )
                        {
                            if(p.Ouro >= Cetro_De_Rá.Preco)
                            {
                                p.Ouro = p.Ouro -Cetro_De_Rá.Preco;
                                p.Itens.Add(Cetro_De_Rá);
                                Console.Clear();
                                Console.WriteLine("(possível)Cetro de Rá comprado e adicionado ao inventário com sucesso!");
                                Console.WriteLine("Então você quer tentar a sorte de ser o legítimo Cetro de Rá hein? Bem, boa sorte com isso!");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }//FIM DO IF
                            else
                            {
                                Console.WriteLine("No Egito todos são ricos, por que acha que eu venderia por essa quantidade minúscula de ouro?");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }//FIM DO ELSE
                        }//FIM DO IF
                         else{
                                Console.Clear();
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                           }//FIM DO ELSE 
                    }//FIM DO ELSE IF


                    else if(ic == Lemegeton.Identificador.ToString())
                    {
                       Console.WriteLine("Você gostaria de comprar " + Lemegeton.Nome + " por " + Lemegeton.Preco + "Ouros? (S)/(N)");
                       Console.WriteLine("Seu ouro:" + p.Ouro);
                       var resp = Console.ReadLine();
                         resp = resp.ToLower();
                        if(resp == "s")
                        {
                            if(p.Ouro >= Lemegeton.Preco)
                            {
                                p.Ouro = p.Ouro - Lemegeton.Preco;
                                p.Itens.Add(Lemegeton);
                                Console.Clear();
                                Console.WriteLine("O Grimório Lemegeton foi comprado e adicionado ao inventário com sucesso!");
                                Console.WriteLine("Cultista? Sério mesmo? Com essa cara?");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }//FIM DO IF
                           else
                            {
                                Console.WriteLine("Não esqueça que Salomão era rei, ele tinha dinheiro, você não..");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }//FIM DO ELSE
                        }//FIM DO IF
                             else{
                                Console.Clear();
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                           }//FIM DO ELSE 
                    }//FIM DO ELSE IF


                    else if(ic == Espada_Matadora_De_Deuses.Identificador.ToString())
                    {

                        Console.WriteLine("Você gostaria de comprar " + Espada_Matadora_De_Deuses.Nome + " por " + Espada_Matadora_De_Deuses.Preco + "Ouros? (S)/(N)");
                        Console.WriteLine("Seu ouro:" + p.Ouro);
                       var resp = Console.ReadLine();
                         resp = resp.ToLower();
                        if(resp == "s")
                        {
                            if(p.Ouro >= Espada_Matadora_De_Deuses.Preco)
                            {
                                p.Ouro = p.Ouro - Espada_Matadora_De_Deuses.Preco;
                                p.Itens.Add(Espada_Matadora_De_Deuses);
                                Console.Clear();
                                Console.WriteLine("A Espada Matadora de Deuses foi comprada e adicionada ao seu inventário com sucesso!");
                                Console.WriteLine("Você não vai sair matando deuses não é mesmo? Me diz que não, por favor!");    
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }//FIM DO IF
                            else
                            {

                                Console.WriteLine("Essa espada matou deuses, tá achando que eu vendo mais barato que isso? Não depois de saber que atravessou os peitos de Hera!");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }//FIM DO ELSE
                        }//FIM DO IF
                        else{
                                Console.Clear();
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                           }//FIM DO ELSE 
                    }//FIM DO ELSE IF


                    else if(ic == Lâminas_Do_Caos.Identificador.ToString())
                    {

                        Console.WriteLine("Você gostaria de comprar " + Lâminas_Do_Caos.Nome + " por " + Lâminas_Do_Caos.Preco + "Ouros? (S)/(N)");
                        Console.WriteLine("Seu ouro:" + p.Ouro);
                       var resp = Console.ReadLine();
                         resp = resp.ToLower();
                        if(resp == "s")
                        {
                            if(p.Ouro >= Lâminas_Do_Caos.Preco)
                            {
                                p.Ouro = p.Ouro - Lâminas_Do_Caos.Preco;
                                p.Itens.Add(Lâminas_Do_Caos);
                                Console.Clear();
                                Console.WriteLine("As Lâminas do Caos foram compradas e adicionadas ao inventário com sucesso!");
                                Console.WriteLine("Cuidado com as correntes, elas pegam fogo também..");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }//FIM DO IF
                            else
                            {

                                Console.WriteLine("Sem dinheiro eu não dou, não elas..");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }//FIM DO ELSE
                        }//FIM DO IF
                        else{
                                Console.Clear();
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                           }//FIM DO ELSE 
                    }//FIM DO ELSE IF


                    else if(ic == Lanche_Da_Mamãe.Identificador.ToString())
                    {

                        Console.WriteLine("Você gostaria de comprar " + Lanche_Da_Mamãe.Nome + " por " + Lanche_Da_Mamãe.Preco + "Ouros? (S)/(N)");
                        Console.WriteLine("Seu ouro:" + p.Ouro);
                       var resp = Console.ReadLine();
                         resp = resp.ToLower();
                        if(resp == "s")
                        {
                            if(p.Ouro >= Lanche_Da_Mamãe.Preco)
                            {
                                p.Ouro = p.Ouro - Lanche_Da_Mamãe.Preco;
                                p.Itens.Add(Lanche_Da_Mamãe);
                                Console.Clear();
                                Console.WriteLine("O Lanche da Mamãe foi comprado e adicionado ao inventário com sucesso!");
                                Console.WriteLine("Parece bem delicioso! Me dá um pedacinho?");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }//FIM DO IF
                            else
                            {

                                Console.WriteLine("Ahhh, é o Lanche da Mamãe, você sabe mais do que eu que vale tudo isso, então torce esse bolso ai!");
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                            }//FIM DO ELSE
                        }//FIM DO IF
                        else{
                                Console.Clear();
                                Console.WriteLine("Pressione qualquer tecla para continuar..");            
                                Console.Read();
                           }//FIM DO ELSE 
                    }//FIM DO ELSE IF


                    else{
                    Console.Clear();
                    Console.WriteLine("Nenhum jogador encontrado...");
                    Console.WriteLine("Insira qualquer tecla para retornar ao menu principal...");
                    Console.ReadLine();
                    }//FIM DO ELSE


                 }//FIM DO IF
            }//FIM DO FOREACH
             return true;//FIM DO SWITCH CASE


            //FIM DO PROGRAMA
            case "5":
                return false;


            //VOLTA AO MENU
            default:
                return true;


        }//FIM DO SWITCH


    }//FIM DO MÉTODO


}//FIM DA CLASSE