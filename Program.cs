using jogo_rpg_c_.src.Entities;

namespace dotnet_pro
{
    class Program{

        static void Main(string[] args){
            
            //Herois
            Knight arus = new Knight("Arus", "Knight", 23, 13, 20);
            Wizard wizard = new Wizard("Jennica", "White Wizard", 23, 21, 62);
        
            //Devil
            Devil evil = new Devil("Thanos", "Knight", 40, 32, 65);
            
            while(true){
                topo:
                
                System.Console.WriteLine(arus.Imprimir());
                System.Console.WriteLine(wizard.Imprimir());
                System.Console.WriteLine(evil.Imprimir());

                if(wizard.defense > 0) System.Console.WriteLine("Digite (1) para ataque do Wizard: ");
                if(arus.defense > 0)System.Console.WriteLine("Digite (2) para ataque do Knight: ");
                System.Console.WriteLine("Digite (3) para ataque do Malvado: ");

                try{
                int opcao = Int32.Parse(s: Console.ReadLine());

                switch(opcao){
                    case 1:
                        if(wizard.defense <=0 ) {
                            System.Console.WriteLine("Heroi morto não pode atacar");
                        }else{
                            evil.SetDefense(evil.defense-wizard.GetPower());
                            System.Console.Write(wizard.Attack());
                            System.Console.WriteLine(", atacou com sucesso o " + evil.nameHero);
                        }
                    break;

                    case 2:
                        if(arus.defense<=0){
                            System.Console.WriteLine("Heroi morto não pode atacar");
                        }else{
                            evil.SetDefense(evil.defense-arus.GetPower());
                            System.Console.Write(arus.Attack());
                            System.Console.WriteLine(", atacou com sucesso o " + evil.nameHero);
                        }
                    break;

                    case 3:
                        if(arus.defense > 0){   
                            arus.SetDefense(arus.defense-evil.GetPower());
                            System.Console.WriteLine(evil.Attack());
                            System.Console.WriteLine("atacou com sucesso o " + arus.nameHero + " ");
                        }else{
                            System.Console.Write(evil.Attack() + ", ");
                        }
                        if(wizard.defense > 0){
                            wizard.SetDefense(wizard.defense-evil.GetPower());
                            System.Console.WriteLine("atacou com sucesso a " + wizard.nameHero);
                        }
                    break;

                    default:
                        System.Console.WriteLine("Você digitou uma opcao invalida, tente novamente! ");
                        Console.ReadLine();
                        Console.Clear();       
                        goto topo;
                }

                Console.ReadLine();
                Console.Clear();


                if(evil.defense <= 0){
                    System.Console.WriteLine("Parabéns, os herois ganharam");
                    break;
                }else if(arus.defense <= 0 && wizard.defense <= 0){
                    System.Console.WriteLine("O malvado ganhou");
                    break;
                }
                
                }
                catch{
                    System.Console.WriteLine("Você digitou uma opcao invalida, tente novamente! ");
                    Console.ReadLine();
                    Console.Clear();       
                    goto topo; 
                }   
            }
        }
    }
}