namespace Atividade {
    class Cliente {
        private string nome {get; set;}
        private string endereco {get; set;}
        private float valor {get; set;}
        private float valor_imposto {get; set;}
        private float total {get; set;}

        public void Pagar_Imposto(float valor) {
            this.valor = valor;
            this.valor_imposto = this.valor * (float)0.1;
            this.total = this.valor + this.valor_imposto;
        }
    }
}