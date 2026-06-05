public class EstacionamentoService
{
    public decimal CalcularValor(DateTime entrada, DateTime saida, TabelaPreco tabela)
    {
        var tempo = saida - entrada;

        if(tempo.TotalMinutes <= 30) return tabela.ValorHoraInicial / 2;
        
        decimal valor = tabela.ValorHoraInicial;

        double minutosRestantes = tempo.TotalMinutes - 60;

        while (minutosRestantes > 10)
        {
            valor += tabela.ValorHoraAdicional;
            minutosRestantes -= 60;
        }

        return valor;
    }
}