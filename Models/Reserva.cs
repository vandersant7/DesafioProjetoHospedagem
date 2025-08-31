namespace ProjetoHospedagem.Models;

internal class Reserva
{
    public List<Pessoa> Hospedes { get; set; }
    public Suite? Suite { get; set; }
    public int DiasReservados { get; set; }

    public Reserva()
    {

    }

    public Reserva(int diasReservados)
    {
        DiasReservados = diasReservados;
    }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        if (Suite == null)
        {
            throw new Exception("É necessário cadastrar uma suíte antes de cadastrar hóspedes.");
        }

        if (hospedes.Count <= Suite.Capacidade)
        {
            Hospedes = hospedes;
        }
        else
        {
            throw new Exception("A quantidade de hóspedes excede a capacidade da suíte.");
        }


    }

    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }

    public decimal CalcularValorDiaria()
    {
        decimal valor = Convert.ToDecimal(DiasReservados) * Suite.ValorDiaria;

        int descontoParaHospedesCom10 = 10;

        if (DiasReservados >= descontoParaHospedesCom10)
        {
            var desconto10PorCento = 0.10M;
            valor -= valor * desconto10PorCento;
        }

        return valor;
    }
    public int ObterQuantidadeHospedes()
    {
        return Hospedes.Count;
    }
    public int ObterQuantidadeSuite()
    {
        return Suite.Capacidade;
    }
}