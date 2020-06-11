using System;
namespace Aula15TryCatch
{
    public class Permissao
    {
        private bool Acesso { get; set; }

        public void Autorizar(){
            System.Console.WriteLine("Acessar aplicação?");

            try{
                Acesso = Boolean.Parse( Console.ReadLine() );
            }catch(Exception ){
                System.Console.WriteLine("Erro nos dados inseridos, utilize apenas true/false.");
            }
        }
    }
}