namespace Aula11Polimorfismo
{
    public class Calcular
    {
        public string calcular(){
        return "A vida do flanco está normal";
        }
        public string calcular(int vida){
            return "O dano causado no flanco é "+ vida;
            
        }
        public string calcular(int vida,int cura){
            return "A vida do flanco curada pelo suporte é "+ (vida + cura);
        }

        public string calcular (string classe,string poder){
            return $" Os atributos do personagem que player escolheu são {classe} {poder} ";
        }
    }
}