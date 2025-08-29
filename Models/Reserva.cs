using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        if (hospedes.Count <= ObterQuantidadeSuite())
        {
            Hospedes = hospedes;
        }
        else
        {
            Console.WriteLine(
            $"Quantidade de {hospedes.Count} hóspede(s) excedeu a capacidade " +
            $"permitida de {ObterQuantidadeSuite()}"
        );
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