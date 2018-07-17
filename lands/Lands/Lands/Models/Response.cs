namespace Lands.Models
{
    //clase que sirve para manejar las respuestas que nos dan los servicios
    public class Response
    {
        //El que intenta traer la lista de paises
        public bool IsSuccess
        {
            get;
            set;
        }

        public string Message
        {
            get;
            set;
        }

        //El que devuelve la lista de paises,si issucces viene true
        public object Result
        {
            get;
            set;
        }
    }
}
