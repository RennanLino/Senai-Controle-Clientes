namespace Entidades {
    class PessoaJuridica : Clientes {

        public string cnpj {get; set;}
        public string ie {get; set;}

        public override void pagarImposto(float valor)
        {
            this.valor = valor;
            this.valorImposto = this.valor * 20 / 100;
            this.total = this.valor + this.valorImposto;
        }
    }
}