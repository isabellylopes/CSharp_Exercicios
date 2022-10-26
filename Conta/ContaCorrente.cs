using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Titular;

namespace ByteBank.Conta
{
    public class ContaCorrente // Representação de uma conta corrente
    {
        public  static int QuantidadeContas { get; private set; }


        // variáveis
        private int num_agencia; // privando variavel


        // cria propriedade que é uma forma de acessar uma variavel privada, ao inves de criar um metodo
        public int Num_agencia
        {
            get { return this.num_agencia; }
            private set { 
                    if(value > 0)
                    {
                        this.num_agencia = value; 
                    }         
                
                }
        }

        //public string conta;

        //Criando propriedade autoincrementada, onde é a variavel é definidade dentro da propriedade

        public string Conta { get; set;}

        private double saldo; // Privando a variavel saldo para que não seja possivel modifica-lá fora da classe

        private Cliente titular { get; set; }

        // metódos
        public void Depositar(double valor) // não irá retornar valor
        {
            saldo += valor; // esse saldo, do objeto em si, vai receber ele + o valor de deposito
        }

        public bool Saque(double valor) // não irá retornar valor
        {
            if (valor <= saldo)
            {
                saldo -= valor; // esse saldo, do objeto em si, vai recever ele - o valor de saque
                return true;

            }

            else { return false; }

        }

        public bool Tranferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;

            }

            else
            {
                Saque(valor);
                destino.Depositar(valor);
                return true;
            }
        }

        // criando um metodo para poder modificar o saldo que está privado e não pode ser alterado no programa principal
        private void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

        // criando um metodo para exibir o saldo que está privado e não pode ser visualizado no programa principal
        public double GetSaldo()
        {
            return this.saldo;
        }

        // criando metodo construtor, ou seja, as regras da classe

        public ContaCorrente (int numeor_agencia, string numero_conta, double saldo)
        {
            this.Num_agencia = numeor_agencia;
            this.Conta = numero_conta;
            this.SetSaldo(saldo);
            QuantidadeContas++;

        }
    }


}
