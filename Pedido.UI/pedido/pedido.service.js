pedidoApp.factory('pedidoService', function ($http) {
    return {
        ListarProdutos: function (callBack) {
            $http.get("http://localhost:63312/api/Produto/Listar/").then(function (response) {
                callBack(response);
            });
        }
    }
});