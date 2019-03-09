(function (app) {
    app.controller('rootController', rootController);
    rootController.$inject = ['$scope', '$state', 'authData', 'loginService', 'authenticationService'];
    function rootController($scope, $state, authData, loginService, authenticationService) {
        $scope.logout = function () {
            console.log('clicked');
            loginService.logOut();
            // log tokeninfo
            console.log(authenticationService.getTokenInfo());
            // go to login
            $state.go('login');
        }

        $scope.authentication = authData.authenticationData;

        authenticationService.validateRequest();
    }
})(angular.module('tedushop'));
