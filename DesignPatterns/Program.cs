using DesignPatterns.Observer;
// See https://aka.ms/new-console-template for more information



var channel = new YoutubeChannel();
var sub1 = new Subscriber(channel);
var sub2 = new Subscriber(channel);

channel.Attach(sub1);
channel.Attach(sub2);

channel.NewVideo("GG WP");
