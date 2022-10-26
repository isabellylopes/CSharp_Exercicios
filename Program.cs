using ByteBank.Conta;
using ByteBank.Titular;

//// Conta Isabely
//ContaCorrente ContaIsabelly = new ContaCorrente();
//Cliente clienteIsabelly = new Cliente();

//ContaIsabelly.titular = clienteIsabelly;


//clienteIsabelly.nome = "Isabelly Lopes";
//clienteIsabelly.cpf = "123456789";
//clienteIsabelly.profissao = "Programadora";
//ContaIsabelly.conta = "1010-X";
//ContaIsabelly.num_agencia = 3010;
//ContaIsabelly.saldo = 100.00;


//// Conta Nataly

//ContaCorrente ContaNataly = new ContaCorrente();
//Cliente clienteNataly = new Cliente();

//ContaNataly.titular = clienteNataly;

//clienteNataly.nome = "Nataly Pecelin";
//clienteNataly.cpf = "123456845";
//clienteNataly.profissao = "Engenheira";
//ContaNataly.conta = "1020-7";
//ContaNataly.num_agencia = 2;
//ContaNataly.saldo = 250.00;


//// Movimentações conta Isabelly

//    Console.WriteLine("Titular da conta: "+ clienteIsabelly.nome);
//    Console.WriteLine("CPF: " + clienteIsabelly.cpf);
//    Console.WriteLine("Saldo atual da conta: "+ ContaIsabelly.saldo);

//    ContaIsabelly.Depositar(50.00);

//    Console.WriteLine("Esse é o valor após deposito: "+ ContaIsabelly.saldo);

//    if(ContaIsabelly.Saque(300.00) == true)
//        {
//            Console.WriteLine("Esse é o valor após saque "+ ContaIsabelly.saldo);
//        }


//    else 
//    { 
//            Console.WriteLine("Não pode sacar, Saldo insuficiente"); 
//    }


//Console.WriteLine("");


//// Movimentações conta Nataly
//Console.WriteLine("Titular da conta: "+clienteNataly.nome);
//Console.WriteLine("CPF: " + clienteNataly.cpf);

//Console.WriteLine("Saldo da Nataly antes da tranferencia: "+ ContaNataly.saldo);


//Console.WriteLine("");


//// Tranferindo da conta da Isabelly para a conta da Nataly
//ContaIsabelly.Tranferir(25.00, ContaNataly);

//Console.WriteLine("Esse é o valor da Isabelly após a transação: " + ContaIsabelly.saldo);

//Console.WriteLine("");


//Console.WriteLine("Esse é o valor da Nataly após a transação " + ContaNataly.saldo);


//ContaCorrente conta3 = new ContaCorrente(15, "1547-P", -1);

//Cliente cliente = new Cliente();

//Console.WriteLine(conta3.GetSaldo());
//Console.WriteLine(conta3.Num_agencia);
//Console.WriteLine(conta3.Conta);
//Console.WriteLine(cliente.Nome);


ContaCorrente conta5 = new ContaCorrente(1, "154-O", 50);
ContaCorrente conta6 = new ContaCorrente(14, "154-P", 50);

Console.WriteLine(ContaCorrente.QuantidadeContas);