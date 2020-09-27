using System;

namespace Backend.Models.Response
{
    public class ListaNegraResponse
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Motivo {get; set;}
        public string Local {get; set;}
        public DateTime? Inclusão {get; set;}
    }
}