angular.
    module('pedidoApp').
    config(['$routeProvider','$httpProvider',
        function config($routeProvider, $httpProvider) {
            $routeProvider.
                when('/pedido', {
                    template: '<pedido-lista></pedido-lista>'
                }).
                when('/pedido/:id', {
                    template: '<pedido-alterar></pedido-alterar>'
                }).
                otherwise('/pedido');

            $httpProvider.useApplyAsync(true);
        }
    ]);