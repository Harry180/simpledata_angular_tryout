var app = angular.module('karolSeals', []);
app.controller("SealController", function () {
	this.Seals = [{ FirstName: "Seal1FirstName", LastName: "Jakas", Age: 22, Photo: null }, { FirstName: "Seal2FirstName", LastName: "Jakas", Age: 13, Photo: null }];
});
