namespace Entidades {

    class Clientes {

        public String nome {get; set;}
        public String endereco {get; set;}
        public float valor {get; protected set;}
        public float valorImposto {get; protected set;}
        public float total {get; protected set;}

        public virtual void pagarImposto(float v) {
            this.valor = v;
            this.valorImposto = this.valor * 10 / 100;
            this.total = this.valor + this.valorImposto;
        }
    }
}