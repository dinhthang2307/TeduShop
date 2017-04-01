(function (app) {
    app.factory('notificationService', notificationService);

    function notificationService() {
        toastr.options = {
            "closeButton": true,
            "debug": true,
            "newestOnTop": false,
            "progressBar": false,
            "positionClass": "toast-top-right",
            "preventDuplicates": false,
            "onclick": null,
            "showDuration": "300",
            "hideDuration": "1000",
            "timeOut": "5000",
            "extendedTimeOut": "1000",
            "showEasing": "swing",
            "hideEasing": "linear",
            "showMethod": "fadeIn",
            "hideMethod": "fadeOut"
        }
       
        function displaySuccess(message) {
            toastr.success(message);
        }

        function displayError(error) {
            if (Array.isArray(error)) {
                error.each(function (error) {
                    toastr.error(error);
                });
            }
            else {
                toastr.error(error);
            }
        }

        function displayWarning(warning) {
            toastr.warning(warning);
        }

        function displayInfo(info) {
            toastr.info(info);
        }
        return {
            displaySuccess: displaySuccess,
            displayWarning: displayWarning,
            displayError: displayError,
            displayInfo: displayInfo
        }

    }

})(angular.module('tedushop.common'));