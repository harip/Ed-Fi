﻿edfiApp.controller('SharedCtrl', function ($scope, sharedService) {

    sharedService.getSystemDate().then(function(result) {
        var date = new Date(result);
        $scope.systemDate = date;
    });

    sharedService.getUserInfo().then(function(result) {
        $scope.userInfo = result;
    });
});
