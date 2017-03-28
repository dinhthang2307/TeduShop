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

        function displayError(Error) {
            if (Array.isArray(error)) {
                error.each(function (err) {
                    toastr.error(err);
                });
            }
            else {
                toastr.error(err);
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