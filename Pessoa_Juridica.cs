namespace Atividade {
    class Pessoa_Juridica : Cliente {
        public string cnpj {get; set;}
        public string ie {get; set;}

        public override void Pagar_Imposto(float valor) {
            this.valor = valor;
            this.valor_imposto = this.valor * (float)0.2;
            this.total = this.valor + this.valor_imposto;
        }
    }
}