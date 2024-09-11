namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");

            // Pedir para o usuário digitar uma placa (ReadLine)
            string placa = Console.ReadLine();

            // Validar se a placa não é nula ou composta de apenas espaços em branco
            if (!string.IsNullOrWhiteSpace(placa))
            {
                // Adicionar na lista "veiculos"
                veiculos.Add(placa.Trim().ToUpper()); // Armazenar em maiúsculas, removendo espaços desnecessários

                // Exibe uma mensagem de sucesso
                Console.WriteLine($"Veículo {placa} adicionado com sucesso.");
            }
            else
            {
                Console.WriteLine("Placa inválida. Tente novamente.");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // Captura de inteiro para variável, usando TryParse para evitar erro de conversão
                if (int.TryParse(Console.ReadLine(), out int horas))
                {
                    // Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                    decimal valorTotal = precoInicial + (precoPorHora * horas); 

                    // Remover a placa digitada da lista de veículos
                    veiculos.Remove(placa.ToUpper());

                    // Mensagem de sucesso
                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
                else
                {
                    Console.WriteLine("Horas inválidas. Tente novamente.");
                }
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente.");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
                // Laço de repetição para exibir os veículos estacionados
                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
