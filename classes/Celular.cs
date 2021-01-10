namespace AulaPOOCelular.classes
{
    public class Celular
    {
        public string modelo;
        public string cor;
        public string tamanho;
        public bool estado;

        public bool DispostivoLigado()
        {
            return estado = true;
        }
        public bool DispostivoDesligado()
        {
            return estado = false;
        }

        public string DispotivoAlerta()
        {
            if(estado == false){
                return ". . . desligado";
            }else{
                return ". . . ligado";
            }
        }

        public string DispostivoChamada()
        {
            if(estado == true){
                return "Insira o número de chamada";
            }else{
                return ". . .";
            }
        }

        public string DispostivoMensagem()
        {
            if(estado == true){
                return "Digite sua mensagem";
            }else{
                return ". . .";
            }
        }
    }
}   