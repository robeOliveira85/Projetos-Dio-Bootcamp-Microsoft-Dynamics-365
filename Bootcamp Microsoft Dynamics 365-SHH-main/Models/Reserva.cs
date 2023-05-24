namespace DesafioProjetoHospedagemHotel.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A quantidade de hóspedes não pode execeder a capacidade de suite");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {   
            return this.Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = 0;
            decimal desconto = 0;
            valor = DiasReservados * Suite.ValorDiaria;
            if (DiasReservados >= 10)
            {
                desconto = valor*10/100;
            }

            return valor - desconto;
        }
    }
}