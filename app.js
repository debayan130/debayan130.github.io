var app=angular.module('myapp',['ngRoute']);

app.config(function($routeProvider,$locationProvider){

        $locationProvider.hashPrefix(''); 
        $routeProvider
       .when('/aboutme',{
        templateUrl: 'aboutme.html',
        controller: "aboutmeCtrl"
        })
        .when('/vb',{
        templateUrl: 'vb.html',
        controller: "vbCtrl"
        })
        .when('/games',{
        templateUrl: 'games.html',
        controller: "gameCtrl"
        })
        .when('/others',{
        templateUrl: 'others.html',
        controller: "othersCtrl"
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
app.controller('vbCtrl',function($scope,$rootScope){
    $rootScope.caro=false;
    }
);
/*app.controller('homeCtrl',function($scope,$rootScope){
    console.log("home called");
    $rootScope.caro=true;
    
    }
);*/
app.controller('gameCtrl',function($scope,$rootScope){
    $rootScope.caro=false;
    }
);
app.controller('othersCtrl',function($scope,$rootScope){
    $rootScope.caro=false;
    }
);