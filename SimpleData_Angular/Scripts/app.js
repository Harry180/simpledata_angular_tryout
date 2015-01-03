var app = angular.module('karolSeals', []);
app.controller("SealController", function () {
	this.Seals = [{ FirstName: "Ola", LastName: "Jakas", Age: 22, Photo: null }, { FirstName: "Kasia", LastName: "Jakas", Age: 13, Photo: null }];
});
