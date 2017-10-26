var app1 = angular.module('app1', []);

app1.controller('ctrl1', function($scope) {
  $scope.first = 1;
  $scope.second = 1;

  $scope.updateValue = funtion() {
    $scope.calculation = $scope.first + ' + ' + $scope.second + " = " +
    (+$scope.first + + $scope.second);

  }
});
