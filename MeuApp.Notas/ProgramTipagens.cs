using System;

namespace MeuApp.Notas
{
    internal class ProgramTipagens
    {
        static void Main(string[] args)
        {
            // NUMEROS INTEIROS
            //---------------------------------------------------------------------------------------------------------------------------------------
            // short idadeShort = 25; --> Variavel int do tipo Short (negativo e positivo)
            // ushort idadeUShort = 25; --> Variavel int do tipo Unsigned Short (apenas positivo)

            // int idadeInt = 25; --> Variavel int do tipo Inteiro (maior que short e positivo/negativo)
            // uint idadeUInt = 25; --> Variavel int do tipo Unsigned Inteiro (maior que short e apenas positivo)

            // long idadeLong = 25; --> Variavel int do tipo Long (maior que inteiro e positivo/negativo)
            // ulong idadeULong = 25; --> Variavel int do tipo Unsigned Long (maior que inteiro e apenas positivo)
            //---------------------------------------------------------------------------------------------------------------------------------------



            // NUMEROS REAIS
            //---------------------------------------------------------------------------------------------------------------------------------------

            // float salarioFloat = 2.500f; (É NECESSÁRIO DEFINIR O "f" no final, para ser reconhecido como um float, e não um double)

            // double salarioDouble = 2.500; (É O INTERMEDIÁRIO E PADRÃO, NÃO PRECISA SER DEFINIDO NO FINAL)

            // var salarioVarDouble = 2.500; (DEFINE AUTOMATICAMENTE O VALOR COMO "DOUBLE")
            // var salarioVarFloat = 2.500f; (define automaticamente o valor como "double", porém converte para float com o "f" no final)
            // var salarioVarDecimal = 2.500m; (DEFINE AUTOMATICAMENTE O VALOR COMO "DOUBLE", PORÉM CONVERTE PARA DECIMAL COM O "m" NO FINAL)

            // decimal salarioDecimal = 2.500m; (É NECESSÁRIO DEFINIR O "m" no final, para ser reconhecido como um decimal, e não um double)

            //---------------------------------------------------------------------------------------------------------------------------------------




            // TIPO BOOLEANO
            //---------------------------------------------------------------------------------------------------------------------------------------

            // bool usuarioJaCadastrado = false;
            // bool pagamentoRecebido = true;
            // var usuarioExpirado = false; ("var" definirá automaticamento como "bool", caso variavel tenha valor atribuido "false" ou "true")

            //---------------------------------------------------------------------------------------------------------------------------------------




            // TIPO CHAR
            //---------------------------------------------------------------------------------------------------------------------------------------

            // char primeiraLetra = 'a'; (CHAR É SEMPRE COM ASPAS SIMPLES (''))
            // var segundaLetra = 'b'; (CASO VALOR DADO SEJA COM ASPAS SIMPLES (''), VAR RECONHECERÁ COMO CHAR

            //---------------------------------------------------------------------------------------------------------------------------------------


            // TIPO STRING (CADEIA DE CARACTERES)
            //---------------------------------------------------------------------------------------------------------------------------------------

            // string nomeArroz = "Arroz"; (STRINGS SÃO DEFINIDAS COM VALORES DADOS ENTRE ASPAS DUPLAS (""))
            // var nomeFeijão = "Feijão"; (CASO VALOR DADO NA VARIAVEL "var" ESTEJA ENTRE ASPAS DUPLAS, SERÁ CONVERTIDO PARA STRING)

            //---------------------------------------------------------------------------------------------------------------------------------------




            // TIPO VAR
            //---------------------------------------------------------------------------------------------------------------------------------------

            // var tipoString = "abcdefg"; (SERÁ DO TIPO STRING, POIS O PRIMEIRO VALOR ATRIBUIDO ESTÁ EM ASPAS DUPLAS (""), OU SEJA, ATRIBUIDO COMO STRING)

            // var tipoInt = 25; (SERÁ DO TIPO INTEIRO, POIS O PRIMEIRO VALOR ATRIBUIDO ESTÁ COMO UM NUMERO INTEIRO))

            // var tipoDouble = 25.7812; (SERÁ DO TIPO DOUBLE, POIS O PRIMEIRO VALOR ATRIBUIDO ESTÁ COMO UM NUMERO DOUBLE (x.x))

            // var tipoBooleano = false; (SERÁ DO TIPO BOOLEANO, POIS O PRIMEIRO VALOR ATRIBUIDO ESTÁ COMO UM BOOL (false ou true))


            //---------------------------------------------------------------------------------------------------------------------------------------


            // TIPO OBJECT
            //---------------------------------------------------------------------------------------------------------------------------------------

            // O tipo object é um tipo desconhecido, pode ser alterado e definido como qualquer tipo de variável, como por exemplo:

            object tipoDesconhecido;
            tipoDesconhecido = 25;
            tipoDesconhecido = 28.8273;
            tipoDesconhecido = "auwhduawhduh";

            // Em nenhuma dessas situações, um erro é reclamado, visto que o valor recebido não é tipado.

            //---------------------------------------------------------------------------------------------------------------------------------------


            // TIPO NULL
            //---------------------------------------------------------------------------------------------------------------------------------------

            // Um tipo de váriavel null recebe um valor vázio, não existente, NÃO é igual a zero, apenas não existe.
            // Exemplo:


            // int? idade = null; (É NECESSARIO COLOCAR "?" após a definição do tipo da variável, para definir como uma variavél de Nullable Type (tipo nulo))

            // float? idadeFloat = null;

            //---------------------------------------------------------------------------------------------------------------------------------------


            // ALIAS
            //---------------------------------------------------------------------------------------------------------------------------------------

            // "Alias" é a simplificação dos nomes dos tipos, para serem reconhecidos de melhor forma no código, por exemplo:

            // int idade = 25; (Alias)
            // Int32 idade = 25; (Nome verdadeiro da chamada do tipo)

            //---------------------------------------------------------------------------------------------------------------------------------------



            // VALORES PADRÕES DE CADA TIPO DE VARÍAVEL
            //---------------------------------------------------------------------------------------------------------------------------------------


            // TODO TIPO DE VARIÁVEL SETARÁ UM VALOR PADRÃO EM SUA VARIÁVEL, UM BUILT-IN PADRÃO, CASO O VALOR NÃO SEJA ESPECIFICADO.


            // Para o tipo de variável "int", o valor padrão sempre será (caso seja non-nullable type (não nulo))
            // int = 0;

            // Para o tipo de variável "float", o valor padrão sempre será (caso seja non-nullable type (não nulo))
            // int = 0;

            // Para o tipo de variável "float", o valor padrão sempre será (caso seja non-nullable type (não nulo))
            // float = 0;

            // Para o tipo de variável "decimal", o valor padrão sempre será (caso seja non-nullable type (não nulo))
            // decimal = 0;

            // Para o tipo de variável "bool", o valor padrão sempre será (caso seja non-nullable type (não nulo))
            // bool = false;

            // Para o tipo de variável "char", o valor padrão sempre será (caso seja non-nullable type (não nulo))
            // char = '/0';

            // Para o tipo de variável "string", o valor padrão sempre será (caso seja non-nullable type (não nulo))
            // string = "";

            //---------------------------------------------------------------------------------------------------------------------------------------




            // CONVERSÕES IMPLÍCITAS
            //---------------------------------------------------------------------------------------------------------------------------------------

            // CONVERSÕES IMPLÍCITAS são conversões que ocorrem entre tipos compátiveis, e que podem ser executadas com uma simples passagem de dados.

            // Exemplo:

            float numeroFloat = 25.982f;
            int numeroInt = 25;

            numeroFloat = numeroInt; // numeroFloat foi de "25.982" para "25".

            //---------------------------------------------------------------------------------------------------------------------------------------




            // CONVERSÕES EXPLÍCITAS
            //---------------------------------------------------------------------------------------------------------------------------------------

            // CONVERSÕES EXPLÍCITAS são conversões que ocorrem entre tipos NÃO compátiveis, e que podem ser executadas atráves da atribuição do tipo entre parênteses,
            // antes do conversão.

            // Exemplo:

            int numeroIntSinal = 100;
            uint numeroIntSemSinal = (uint)numeroIntSinal;

            // Outro exemplo:

            float numeroFloatExp = 17.92f;
            double numeroDoubleExp = (double)numeroFloatExp;


            //---------------------------------------------------------------------------------------------------------------------------------------




            // PARSE

            //---------------------------------------------------------------------------------------------------------------------------------------

            // O comando "Parse" é utilizado para converter uma cadeia de caracteres (string) em um tipo de variável que o developer deseja.

            // Exemplo:

            var variableParse = "250"; // Define a variável como string (O COMANDO PARSE SOMENTE RECEBERÁ VALORES EM STRING)

            float floatParse = float.Parse(variableParse); // Transforma o valor da variableParse (string) no valor do tipo desejado pelo developer (float)
            int intParse = int.Parse(variableParse); // Transforma o valor da variableParse (string) no valor do tipo desejado pelo developer (int)
            double doubleParse = double.Parse(variableParse); // Transforma o valor da variableParse (string) no valor do tipo desejado pelo developer (double)         

            //---------------------------------------------------------------------------------------------------------------------------------------


            // CONVERT
            //---------------------------------------------------------------------------------------------------------------------------------------

            // Convert é um comando utilizado para converter o valor de uma varíavel para um tipo requerido pelo desenvolvedor.

            // Exemplo:

            var numeroConvert = 25.8f;
            float floatConvert = Convert.ToInt32(numeroConvert);
            Console.WriteLine(numeroConvert);


            //---------------------------------------------------------------------------------------------------------------------------------------


            //---------------------------------------------------------------------------------------------------------------------------------------

            //---------------------------------------------------------------------------------------------------------------------------------------
        }
    }
}
