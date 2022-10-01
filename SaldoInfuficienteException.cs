namespace SistemaBanco
{
    public class SaldoInfuficienteException : OperacaoFinanceiraException
    {
        public decimal ValorSaque { get; }
        public decimal Saldo { get; }
        public SaldoInfuficienteException() { }
        public SaldoInfuficienteException(decimal valorSaque, decimal saldo)
        : this($"Tentativa de saque R$ {valorSaque} inválida. Pois o saldo da conta é de R$ {saldo}.")
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }
        public SaldoInfuficienteException(string? message)
        : base(message) { }

        public SaldoInfuficienteException(string? message, Exception innerException)
        : base(message, innerException) { }

    }
}