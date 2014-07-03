using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using Microsoft.Owin.Security.OAuth;
using Newtonsoft.Json.Serialization;
using System.Net.Http.Headers;

namespace TWTwitter
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/plain"));
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "MessageApi",
                routeTemplate: "api/Messages/{id}",
                defaults: new { controller = "apiMessage", id = RouteParameter.Optional }
            ); 
            config.Routes.MapHttpRoute(
                name: "MyTweetsApi",
                routeTemplate: "api/MyTweets/{id}",
                defaults: new { controller = "apiUserTweets", id = RouteParameter.Optional }
            ); 
            config.Routes.MapHttpRoute(
                name: "UsersApi",
                routeTemplate: "api/Users/{id}",
                defaults: new { controller = "apiUsers", id = RouteParameter.Optional }
            ); 
            config.Routes.MapHttpRoute(
                name: "TweetApi",
                routeTemplate: "api/Tweet/{id}",
                defaults: new { controller = "apiTweet", id = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
                name: "FollowingApi",
                routeTemplate: "api/Following/{id}",
                defaults: new { controller = "apiFollowing", id = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
                name: "FollowersApi",
                routeTemplate: "api/Followers/{id}",
                defaults: new { controller = "apiFollowers", id = RouteParameter.Optional }
            ); 
            config.Routes.MapHttpRoute(
                 name: "DefaultApi",
                 routeTemplate: "api/{controller}/{id}",
                 defaults: new { id = RouteParameter.Optional }
             );
        }
    }
}
