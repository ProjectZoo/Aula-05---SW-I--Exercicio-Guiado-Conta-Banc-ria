namespace conta_bancaria;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Exercicio Conta Bancária - ETECMCM");
        Conta conta = new Conta();

        conta.nomeCliente = "Anderson Vanin";
        conta.limite = 500;
        conta.depositar(200);
        //conta.numeroConta = 123;
        //conta.limite = 500;
        //conta.saldo = 500000;

        //Console.WriteLine("Olá, " + conta.nomeCliente + ", seu saldo é de: " + conta.saldo);
        //Console.WriteLine("Seu Limite de saque é de: " + conta.saldo);
        //Console.WriteLine("O número de sua conta é: " + conta.numeroConta);
        //Vamos chamar o método ConsultaSaldo e receber em uma variável local chamada saldo o valor disponível em saldo desse cliente
        conta.sacar(50);
    
        double saldo = conta.ConsultaSaldo();
        //Visualizar:
        Console.WriteLine("Seu saldo é de: " + saldo);
    }
}
