namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal PricingStart { get; set; } = 0;
        private decimal PricingByHour { get; set; } = 0;
        private List<string> Vehicles = new List<string>();

        public Estacionamento(decimal PricingStart, decimal PricingByHour)
        {
            this.PricingStart = PricingStart;
            this.PricingByHour = PricingByHour;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "Vehicles"
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            var placa = Console.ReadLine();
            Vehicles.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (Vehicles.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "PricingStart + PricingByHour * horas" para a variável valorTotal                
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = PricingStart + PricingByHour * horas;

                // TODO: Remover a placa digitada da lista de veículos
                this.Vehicles.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVehicles()
        {
            // Verifica se há veículos no estacionamento
            if (Vehicles.Count != 0)
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                this.Vehicles.ForEach(veiculo => Console.WriteLine(veiculo));
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
