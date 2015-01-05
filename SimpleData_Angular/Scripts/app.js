
var app = angular.module('karolSeals', []);
app.controller("SealController", ['$scope', '$http', function ($scope, $http) {
	var self = this;
	self.seals = [];

	$http.get('http://simpledata.com/Seal/GetSeals').success(function (data) {
		self.seals = data;
	});
	//TODO: Is this good approach for passing value: google it !
	self.editSeal = function (seal) {
		$scope.$broadcast('sealEdit', seal);
	};
}]);

app.controller('DetailsController', ['$scope', '$http', function ($scope, $http) {
	var self = this;
	self.sealModel = {};

	$scope.$on('sealEdit', function (response) {
		console.log(response);
	});

	self.submitSeal = function () {

	};

}]);

$(function () {
	$('#sealFormWindow').dialog({
		autoOpen: false,
		height: 300,
		width: 350,
		modal: true
	});
});
