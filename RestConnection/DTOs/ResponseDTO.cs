using System.Dynamic;
using System.Net;

namespace RestConnection.DTOs
{
    public class ResponseDTO<T> where T : class
    {
        public HttpStatusCode CodigoHttp { get; set; }
        public T? Dados { get; set; }
        public ExpandoObject? Erro { get; set; }
    }
}
