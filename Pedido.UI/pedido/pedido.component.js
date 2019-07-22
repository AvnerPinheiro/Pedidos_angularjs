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
    var model = this;
    model.pedido = {};
    model.pedido.Produtos = [];
    model.pedido.Total = 500;

    pedidoService.ListarProdutos(function (response) {
        model.produtos = response.data;
    });

    model.AdicionarProduto = function () {
        if (model.produtoSelecionado) {
            let obj = model.produtos.filter((produto) => {
                return produto.ProdutoId == model.produtoSelecionado;
            });
            if (obj.length > 0) {
                model.pedido.Produtos.push(obj[0]);
            }
            AtualizarTotal();
        }
    }

    model.RemoverProduto = function (index) {
        model.pedido.Produtos.splice(index, 1);
        AtualizarTotal();
    }

    model.Salvar = function () {
        console.log(model.pedido);
    }

    function AtualizarTotal() {
        model.pedido.Total = 0;
        model.pedido.Produtos.forEach(function (obj, index) {
            model.pedido.Total += obj.Valor;
        });
    }
}