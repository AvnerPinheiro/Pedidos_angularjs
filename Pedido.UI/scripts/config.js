angular.
    module('pedidoApp').
    config(['$routeProvider',
        function config($routeProvider) {
            $routeProvider.
                when('/pedido', {
                    template: '<pedido-lista></pedido-lista>'
                }).
                when('/pedido/:id', {
                    template: '<pedido-alterar></pedido-alterar>'
                }).
                otherwise('/pedido');
        }
    ]);