using System;



class HelloWorld {
     static void Main () {
        string j_player= capturarJogada();
        string j_pc = jogadaAleatoria();
        determinaJogador(j_player,j_pc);
        
        
     }
    
    
    static string capturarJogada()
    {
        Console.WriteLine("========Pedra(P), Papel(L), Tesoura(T)========= ");
        Console.WriteLine("Digite sua jogada: ");
        string jogada_player = Console.ReadLine();
        
        return jogada_player;
    }
    
    static string jogadaAleatoria(){
        
        string sorteio;
        Random numAleatorio = new Random();
        int num = numAleatorio.Next(1,4);
        
        if(num == 1){
            
            sorteio = "P";
        }
        else if(num == 2){
            
            sorteio = "L";
        }
        else{
            sorteio = "T";
        }
        return sorteio;
    }
    
    static void determinaJogador(string jogada_player, string sorteio){
        
        
        
        if (jogada_player== "P" && sorteio== "P"){
            Console.WriteLine("Adversário :" + sorteio);
            Console.WriteLine("Deu impate");
        }
        
        else if (jogada_player== "P" && sorteio== "L"){
            Console.WriteLine("Adversário :" + sorteio);
            Console.WriteLine("Seu adversário venceu!");
        }
        
        else if (jogada_player== "P" && sorteio== "T"){
            Console.WriteLine("Adversário :" + sorteio);
             Console.WriteLine("Você venceu!");
        }
        else if (jogada_player== "L" && sorteio== "P"){
            Console.WriteLine("Adversário :" + sorteio);
             Console.WriteLine("Você venceu!");
        }
        else if (jogada_player == "T" && sorteio == "L"){
            Console.WriteLine("Adversário :" + sorteio);
             Console.WriteLine("Deu impate");
        }
         if (jogada_player== "L" && sorteio== "T"){
             Console.WriteLine("Adversário :" + sorteio);
             Console.WriteLine("Seu adversário venceu!");
        }
         if (jogada_player== "T" && sorteio== "P"){
             Console.WriteLine("Adversário :" + sorteio);
             Console.WriteLine("Seu adversário venceu!");
        }
         if (jogada_player== "T" && sorteio== "L"){
            Console.WriteLine("Adversário :" + sorteio);
            Console.WriteLine("Você venceu!");
        }
         if (jogada_player== "T" && sorteio== "T"){
             Console.WriteLine("Adversário :" + sorteio);
             Console.WriteLine("Deu impate");
        }
        
        
        
        
        
    }
    
}
    

    
