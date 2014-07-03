var loggedIn = false;
var currentUser = "Waycious";
var app = angular.module('app', ['ngResource'])

.factory('Twitter', function ($resource) {
    return {
        Tweet: $resource("/api/Tweet/:id"),
        Users: $resource("/api/Users/:id"),
        Followers: $resource("/api/Followers/:id"),
        Following: $resource("/api/Following/:id"),
        UserTweets: $resource("/api/MyTweets/:id"),
        Messages: $resource("/api/Messages/:id")
    }

})
.controller('TweetCtrl', function (Twitter, $scope, $http) {
    $scope.userId = currentUser;
    Twitter.UserTweets.query({ id: "Waycious" }, function (data) {
        $scope.UserTweets = data.reverse();
    });
    Twitter.Tweet.query(function (data) {
        $scope.Tweets = data.reverse();
    });
    Twitter.Users.query(function (data) {
        $scope.DirectMessageTargets = data;
        $scope.Users = data;
    });
    Twitter.Followers.query({ id: currentUser }, function (data) {
        $scope.Followers = data;
    });
    Twitter.Following.query({ id: currentUser }, function (data) {
        $scope.Following = data;
    });
    Twitter.Messages.query({ id: currentUser }, function (data) {
        $scope.Messages = data.reverse();
    });


    $scope.postTweet = function () {
        var tweet = {};
        var targetId;
        var text;
        if ($scope.tweet.charAt(0) == "@") {
            targetId = $scope.tweet.split(" ")[0].substring(1);
            text = $scope.tweet.substring(targetId.length + 1);
            $scope.test1 = targetId;
            $scope.test2 = text;
        } else {
            text = $scope.tweet;
            targetId = null;
        }
        tweet.UserId = currentUser;
        tweet.TargetId = targetId;
        tweet.Text = text;
        Twitter.Tweet.save(tweet, function () {
            Twitter.Tweet.query(function (data) {
                $scope.Tweets = data;
            });
        });
    };
    $scope.sendDM = function () {
        var message = {};
        message.UserId = currentUser;
        message.TargetId = $scope.DirectMessageTarget.Id;
        message.Text = $scope.DirectMessageText;
        message.Subject = $scope.DirectMessageSubject;
        Twitter.Messages.save(message, function () {
            $scope.DirectMessageTarget = "";
            $scope.DirectMessageText = "";
            $scope.DirectMessageSubject = "";
            Twitter.Messages.query({ id: currentUser }, function (data) {
                $scope.Messages = data;
            });
        });
    }
});
