using UsersHub.HUB;
using UsersHub.Users;

var us = new User("sd", "sd", "sd");
var us1 = new User("sd", "sd", "2sd");
var us2 = new User("3sd", "sd", "3sd");
var us3 = new User("4sd", "sd", "4sd");
var us4 = new User("5sd", "sd", "sd");


var reg = new RegistorByDictionary();

reg.AddUser(us);
reg.AddUser(us1);
reg.AddUser(us2);
reg.AddUser(us3);
reg.AddUser(us4);



reg.RemoveUser(1);
reg.RemoveUser(2);



reg.AddUser(us);
reg.AddUser(us1);

reg.AddUser(us1);



Console.WriteLine("d");

