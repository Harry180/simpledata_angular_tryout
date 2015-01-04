var app = angular.module('karolSeals', []);
app.controller("SealController", ['$http', function ($http) {
	var self = this;
	self.seals = [];

	$http.get('http://simpledata.com/Seal/GetSeals').success(function (data) {
		self.seals = data;
	});
}]);
