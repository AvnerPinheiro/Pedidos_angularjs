angular.
    module('pedidoApp').
    component('pedidoLista', {
        templateUrl: 'pedido/pedido-lista.html',
        controller: function PedidoListaController() {
            this.alterar = function (id) {

            }
            this.excluir = function (id) {
                var certeza = confirm("Você tem certeza que deseja excluir?");
                if (certeza) {
                    alert("Excluido " + id);
                }
            }
        }
    });

angular.
    module('pedidoApp').
    component('pedidoAlterar', {
        templateUrl: 'pedido/pedido-alterar.html',
        controller: ['$scope', 'pedidoService', PedidoAlterarController]
    });

function PedidoAlterarController($scope, pedidoService) {
    this.pedido = {};
    this.pedido.Produtos = [];

    pedidoService.ListarProdutos(function (response) {
        this.produtos = response.data;
    });

    this.AdicionarProduto = function () {
        if (this.produtoSelecionado) {
            let obj = this.produtos.filter((produto) => {
                return produto.idProduto == this.produtoSelecionado;
            });
            if (obj.length > 0) {
                this.pedido.Produtos.push(obj[0]);
            }
        }
    }

    this.RemoverProduto = function (index) {
        this.pedido.Produtos.splice(index, 1);
    }

    this.Salvar = function () {
        console.log(this.pedido);
    }
}