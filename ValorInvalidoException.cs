namespace SistemaBanco
{
    public class ValorInvalidoException : ArgumentException
    {
        public decimal Valor { get; }
        public ValorInvalidoException() { }

        public ValorInvalidoException(decimal valor)
        : this($"Valor R$ {valor} digitado inválido.")
        {
            Valor = valor;
        }

        public ValorInvalidoException(string? message, string? paramName)
        : base(message, paramName) { }

        public ValorInvalidoException(string? message)
        : base(message) { }

        public ValorInvalidoException(string? message, Exception innerException)
        : base(message, innerException) { }
    }
}