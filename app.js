var app=angular.module('myapp',['ngRoute']);

app.config(function($routeProvider,$locationProvider){

        $locationProvider.hashPrefix(''); 
        $routeProvider
       .when('/aboutme',{
        templateUrl: 'aboutme.html',
        controller: "aboutmeCtrl"
        })
        .when('/',{
        template: '',
        controller: "myCtrl"
        });
        
});


app.controller('myCtrl',function($scope,$rootScope){
    $rootScope.caro=true;
    }
);
app.controller('aboutmeCtrl',function($scope,$rootScope){
    console.log("aboutme called");
    $rootScope.caro=false;
    
    }
);
/*app.controller('homeCtrl',function($scope,$rootScope){
    console.log("home called");
    $rootScope.caro=true;
    
    }
);*/
