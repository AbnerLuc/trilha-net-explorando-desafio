namespace DesafioProjetoHospedagem.Models
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
           //   Feito
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                //Feito
                throw new Exception("O Número de hospedes excede a capacidade da suite");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
           //Feito
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            //Feito
            decimal valor = DiasReservados * Suite.ValorDiaria;


            // Feito
            if (DiasReservados >= 10)
            {
                decimal desconto = (10 * valor) / 100;
                valor = valor - desconto;
            }

            return valor;
        }
    }
}