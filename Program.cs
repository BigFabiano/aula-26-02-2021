using  System ;

namespace  aula_26_02_2021
{
     programa de aula
    {
        static  void  Main ( string [] args )
        {
            string  nomeDoAluno ;

            Console . Limpar ();
            Console . Beep ();

            Console . Write ( " Olá, aluno. Por favor digite seu nome: " );
            nomeDoAluno  =  Console . ReadLine ();

            Console . ForegroundColor  =  ConsoleColor . Vermelho ;
            Console . WriteLine ( " Lista de alunos malvados " );
            Console . WriteLine ( " ------------------------ " );
            Console . ForegroundColor  =  ConsoleColor . Verde ;
            Console . WriteLine ();

            Console . WriteLine ( " 1. Zezinho " );
            Console . WriteLine ( " 2. Mariazinha " );
            Console . WriteLine ( " 3. Pedrinho " );
            Console . WriteLine ( " 4. Jorginho " );
            Console . WriteLine ( $ " 5. { nomeDoAluno } " );

            Console . WriteLine ();
            Console . ForegroundColor  =  ConsoleColor . Vermelho ;
            Console . WriteLine ( " Vão todos para a diretoria! " );
            Console . Beep ();
            Console . ResetColor ();

            Console . Write ( " Pressione uma tecla para continuar ... " );
            Console . ReadKey ();
        }
    }
}